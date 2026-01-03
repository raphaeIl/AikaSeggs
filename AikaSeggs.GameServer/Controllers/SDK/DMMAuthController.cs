using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.IO.Compression;
using System.Text;
using System.Security.Cryptography;
using AikaSeggs.Common.Utils;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;

namespace AikaSeggs.GameServer.Controllers.SDK
{
    [ApiController]
    public class DMMAuthController : ControllerBase
    {
        private readonly AikaSeggsContext _context;

        public DMMAuthController(AikaSeggsContext context)
        {
            _context = context;
        }

        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private static string GenerateUserId()
        {
            return Guid.NewGuid().ToString("N");
        }

        private static string GetHtmlContent(string fileName)
        {
            // Try Config.ResourceDir first (if Resources is in bin directory)
            var htmlPath = Path.Combine(Config.ResourceDir, "Html", fileName);
            
            if (System.IO.File.Exists(htmlPath))
            {
                return System.IO.File.ReadAllText(htmlPath);
            }
            
            // Fallback: Try relative to project root (Resources is at project root level)
            var baseDir = Path.GetDirectoryName(AppContext.BaseDirectory) ?? Directory.GetCurrentDirectory();
            // Go up from bin/Debug/net8.0 to project root
            var projectRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", ".."));
            htmlPath = Path.Combine(projectRoot, "Resources", "Html", fileName);
            
            if (System.IO.File.Exists(htmlPath))
            {
                return System.IO.File.ReadAllText(htmlPath);
            }
            
            Log.Error("HTML file not found at: {Path} (also tried: {FallbackPath})", Path.Combine(Config.ResourceDir, "Html", fileName), htmlPath);
            return $"<!DOCTYPE html><html><body>Error: {fileName} not found.</body></html>";
        }

        private static string GetEmailConfirmHtml()
        {
            return GetHtmlContent("signup_email_confirm.html");
        }

        private static string GetEmailCompleteHtml()
        {
            return GetHtmlContent("signup_email_complete.html");
        }

        private static string GetLoginPasswordWrongHtml()
        {
            return GetHtmlContent("login_password_error.html");
        }

        [HttpPost]
        [Route("/welcome/signup/email/apply/=/channel=games")]
        public IResult SignupEmailApply()
        {
            string? email = null;
            string? password = null;

            // Extract email and password from form
            if (Request.HasFormContentType)
            {
                if (Request.Form.ContainsKey("email"))
                {
                    email = Request.Form["email"].ToString();
                }
                if (Request.Form.ContainsKey("password"))
                {
                    password = Request.Form["password"].ToString();
                }
            }

            // Create account if email and password are provided
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    // Check if account already exists
                    var existingAccount = _context.Accounts.FirstOrDefault(a => a.Email == email);
                    if (existingAccount == null)
                    {
                        // Create new account
                        var userId = GenerateUserId();
                        var account = new AccountDB
                        {
                            UserId = userId,
                            UserCd = userId,
                            Email = email,
                            PasswordHash = HashPassword(password),
                            UserName = email.Split('@')[0], // Use email prefix as username
                            Level = 1,
                            Exp = 0,
                            FreeGem = 0,
                            PaidGem = 0,
                            RegisterDate = DateTime.Now.ToString("yyyyMMddHHmmss")
                        };

                        _context.Accounts.Add(account);
                        _context.SaveChanges();

                        Log.Information("Account created: {Email}", email);
                    }
                    else
                    {
                        Log.Warning("Account already exists: {Email}", email);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Failed to create account for: {Email}", email);
                }
            }

            // Return the confirmation URL with email as query parameter
            var emailParam = !string.IsNullOrEmpty(email) ? Uri.EscapeDataString(email) : "";
            var response = $"/welcome/signup/email/confirm/=/channel=games?registration_id=101000-f08ee1b6-34a4-8e11-cfe5-7834786f4ae5&email={emailParam}";
            return Results.Redirect(response);
        }

        [HttpGet]
        [Route("/welcome/signup/email/confirm/=/channel=games")]
        public async Task SignupEmailConfirm()
        {
            // Get email from query parameters
            string? email = null;
            if (Request.Query.ContainsKey("email"))
            {
                email = Request.Query["email"].ToString();
            }

            var htmlContent = GetEmailConfirmHtml();
            
            // Replace template email with actual email if provided
            if (!string.IsNullOrEmpty(email))
            {
                htmlContent = htmlContent.Replace("template_email@gmail.com", email);
            }

            var htmlBytes = Encoding.UTF8.GetBytes(htmlContent);

            // Set essential response headers
            Response.ContentType = "text/html; charset=utf-8";
            Response.Headers["Content-Encoding"] = "gzip";
            Response.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate";
            Response.Headers["Set-Cookie"] = "ckcy=1; path=/; expires=Sat, 02 Jan 2027 09:41:59 GMT; domain=dmm.co.jp; samesite=none; secure";

            // Compress and write to response body
            using (var outputStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(outputStream, CompressionLevel.Fastest))
                {
                    await gzipStream.WriteAsync(htmlBytes, 0, htmlBytes.Length);
                }
                var compressedBytes = outputStream.ToArray();
                Response.ContentLength = compressedBytes.Length;
                await Response.Body.WriteAsync(compressedBytes, 0, compressedBytes.Length);
            }
        }

        [HttpPost]
        [Route("/welcome/signup/email/complete/=/channel=games")]
        public async Task SignupEmailComplete()
        {
            var htmlContent = GetEmailCompleteHtml();
            var htmlBytes = Encoding.UTF8.GetBytes(htmlContent);

            // Set essential response headers
            Response.ContentType = "text/html; charset=utf-8";
            Response.Headers["Content-Encoding"] = "gzip";
            Response.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate";

            // Set multiple Set-Cookie headers
            Response.Headers.Append("Set-Cookie", "ckcy=1; path=/; expires=Sat, 02 Jan 2027 09:46:56 GMT; domain=dmm.co.jp; samesite=none; secure");
            Response.Headers.Append("Set-Cookie", "INT_SESID=A1lRXE9CCQJYQTR6d0cKEF9XAlkQUgIGWFYCV11JBFUHVU9SBQBRHFpbB1EeVQIBAQdWAgdUUlJYFl1CX1EIQDE3IzRgEwhYWFJWBQRWBVRXVQJYQVtdCht9KGU6N3cxKydAXVULBQsZEFsACUdkKiFGDxAIUlIKGwZXBF1dClAHTlpSUFQeBQdTUR4KBghTSAIBBgdYBgINUlAAB0YJEVhaWERZVF5TBxE%2BWldHChBfVQZZECVVAAkEH0YXDwdbD0FZFQ4ECRMGAT5aV0cKEF9VDkEAQ19DAwNcExAXVxA9CgZED0IJAFRZQ3pfCVUGAhMHCwALFABIUzwTXhcIW1hBAxNAWWxFCw4EEQgMC1JSUgNQBlZWAQ8PFQtUVQhABhYSCl1SUkULDA8RCBYLU19GFlhPHA%3D%3D; path=/; domain=dmm.co.jp");
            Response.Headers.Append("Set-Cookie", "INT_SESID_SECURE=A1lRXE9CCQJYQTR6d0cKEF9XAlkQUgIGWFYCV11JBFUHVU9SBQBRHFpbB1EeVQIBAQdWAgdUUlJYFl1CX1EIQDE3IzRgEwhYWFJWBQRWBVRXVQJYQVtdCht9KGU6N3cxKydAXVULBQsZEFsACUdkKiFGDxAIUlIKGwZXBF1dClAHTlpSUFQeBQdTUR4KBghTSAIBBgdYBgINUlAAB0YJEVhaWERZVF5TBxE%2BWldHChBfVQZZECVVAAkEH0YXDwdbD0FZFQ4ECRMGAT5aV0cKEF9VDkEAQ19DAwNcExAXVxA9CgZED0IJAFRZQ3pfCVUGAhMHCwALFABIUzwTXhcIW1hBAxNAWWxFCw4EEQgMC1JSUgNQBlZWAQ8PFQtUVQhABhYSCl1SUkULDA8RCBYLU19GFlhPHA%3D%3D; path=/; domain=dmm.co.jp; samesite=none; secure");
            Response.Headers.Append("Set-Cookie", "secid=e59f4ecdb4250a76549a3a6475c9d601; path=/; expires=Sat, 02 Jan 2027 09:46:56 GMT; domain=dmm.co.jp; samesite=none; secure; httponly");
            Response.Headers.Append("Set-Cookie", "login_secure_id=e59f4ecdb4250a76549a3a6475c9d601; path=/; expires=Sat, 02 Jan 2027 09:46:56 GMT; domain=dmm.co.jp; secure; httponly");
            Response.Headers.Append("Set-Cookie", "login_session_id=2158982e-84de-4e00-9c90-f5e59b24f61b; path=/; domain=dmm.co.jp");
            Response.Headers.Append("Set-Cookie", "i3_opnd=Illdegw3h2jp0qgZ; path=/; domain=dmm.co.jp; samesite=none; secure");
            Response.Headers.Append("Set-Cookie", "check_done_login=true; path=/; expires=Sat, 02 Jan 2027 09:46:56 GMT; domain=dmm.co.jp; httponly");
            Response.Headers.Append("Set-Cookie", "subscription_members_status=non; path=/; expires=Sun, 01 Feb 2026 09:46:56 GMT; domain=dmm.co.jp");
            Response.Headers.Append("Set-Cookie", "latestlogin=email; path=/; expires=Sat, 02 Jan 2027 09:46:56 GMT; domain=accounts.dmm.co.jp; samesite=none; secure; httponly");
            Response.Headers.Append("Set-Cookie", "ckcy_remedied_check=ktkrt_argt; path=/; domain=dmm.co.jp");

            // Compress and write to response body
            using (var outputStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(outputStream, CompressionLevel.Fastest))
                {
                    await gzipStream.WriteAsync(htmlBytes, 0, htmlBytes.Length);
                }
                var compressedBytes = outputStream.ToArray();
                Response.ContentLength = compressedBytes.Length;
                await Response.Body.WriteAsync(compressedBytes, 0, compressedBytes.Length);
            }
        }

        [HttpPost]
        [Route("/service/login/password/authenticate")]
        public IResult PasswordAuthenticate()
        {
            string? loginId = null;
            string? password = null;
            
            // Extract login_id and password from form
            if (Request.HasFormContentType)
            {
                if (Request.Form.ContainsKey("login_id"))
                {
                    loginId = Request.Form["login_id"].ToString();
                }

                if (Request.Form.ContainsKey("password"))
                {
                    password = Request.Form["password"].ToString();
                }
            }

            // Log account and password
            if (!string.IsNullOrEmpty(loginId) || !string.IsNullOrEmpty(password))
            {
                Log.Information("Account: {LoginId}, Password: {Password}", loginId ?? "N/A", password ?? "N/A");
            }

            // Validate credentials
            bool loginSuccess = false;
            if (!string.IsNullOrEmpty(loginId) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    var account = _context.Accounts.FirstOrDefault(a => a.Email == loginId);
                    if (account != null)
                    {
                        var passwordHash = HashPassword(password);
                        if (account.PasswordHash == passwordHash)
                        {
                            loginSuccess = true;
                            Log.Information("Login successful for: {LoginId}", loginId);
                        }
                        else
                        {
                            Log.Warning("Invalid password for: {LoginId}", loginId);
                        }
                    }
                    else
                    {
                        Log.Warning("Account not found: {LoginId}", loginId);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Error during login for: {LoginId}", loginId);
                }
            }

            if (!loginSuccess)
            {
                // Wrong credentials - redirect to login page
                var path = Request.Form.ContainsKey("path") ? Request.Form["path"].ToString() : "https%3A%2F%2Fartemis.games.dmm.co.jp%2Fmember%2Fpc%2Finit-game-frame%2Fdeeponer";
                var channel = Request.Form.ContainsKey("channel") ? Request.Form["channel"].ToString() : "games";
                var redirectUrl = $"/service/login/password/=/path={path}/channel={channel}";
                return Results.Redirect(redirectUrl);
            }

            // Set response headers for successful login
            var expiresDate = DateTime.UtcNow.AddYears(1).ToString("ddd, dd MMM yyyy HH:mm:ss GMT");
            var expiresDateShort = DateTime.UtcNow.AddMonths(1).ToString("ddd, dd MMM yyyy HH:mm:ss GMT");

            // Set multiple Set-Cookie headers
           Response.Headers.Append("Set-Cookie", $"check_done_login=true; path=/; expires={expiresDate}; domain=dmm.co.jp; httponly");
            Response.Headers.Append("Set-Cookie", $"subscription_members_status=non; path=/; expires={expiresDateShort}; domain=dmm.co.jp");
            Response.Headers.Append("Set-Cookie", $"latestlogin=email; path=/; expires={expiresDate}; domain=accounts.dmm.co.jp; samesite=none; secure; httponly");
            Response.Headers.Append("Set-Cookie", "ckcy_remedied_check=ktkrt_argt; path=/; domain=dmm.co.jp");

            // Redirect to the game frame URL
            return Results.Redirect("https://artemis.games.dmm.co.jp/member/pc/init-game-frame/deeponer");
        }

        [HttpGet]
        [Route("/service/login/password/{**remaining}")]
        public async Task LoginPasswordPage(string remaining)
        {
            // Parse path and channel from the remaining path
            // Format: path=https%3A%2F%2Fartemis.games.dmm.co.jp%2Fmember%2Fpc%2Finit-game-frame%2Fdeeponer/channel=games
            string? path = null;
            string? channel = null;
            
            if (!string.IsNullOrEmpty(remaining))
            {
                var parts = remaining.Split('/');
                foreach (var part in parts)
                {
                    if (part.StartsWith("path="))
                    {
                        path = part.Substring(5); // Remove "path=" prefix
                    }
                    else if (part.StartsWith("channel="))
                    {
                        channel = part.Substring(8); // Remove "channel=" prefix
                    }
                }
            }

            var htmlContent = GetLoginPasswordWrongHtml();
            var htmlBytes = Encoding.UTF8.GetBytes(htmlContent);

            // Set essential response headers
            Response.ContentType = "text/html; charset=utf-8";
            Response.Headers["Content-Encoding"] = "gzip";
            Response.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate";

            // Compress and write to response body
            using (var outputStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(outputStream, CompressionLevel.Fastest))
                {
                    await gzipStream.WriteAsync(htmlBytes, 0, htmlBytes.Length);
                }
                var compressedBytes = outputStream.ToArray();
                Response.ContentLength = compressedBytes.Length;
                await Response.Body.WriteAsync(compressedBytes, 0, compressedBytes.Length);
            }
        }
    }
}
