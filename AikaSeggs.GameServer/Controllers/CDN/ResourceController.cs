 using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text;

namespace AikaSeggs.GameServer.Controllers
{
    [Route("/")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private const string LOCAL_PROJECT_JS = @"E:\documents\Decompiling\Extracted\DeepOne\AikaDumper\project.js";
        private const string LOCAL_STORY_TEST = @"E:\documents\Decompiling\Extracted\DeepOne\AikaSeggs\AikaSeggs.GameServer\Controllers\CDN\0b28d5f523614f88989ca79def871b2d.txt";
        private const string LOCAL_MP4_PATH = @"E:\documents\Decompiling\Extracted\DeepOne\AikaSeggs\AikaSeggs.GameServer\Controllers\CDN\dd9acdabf7151ba50e5738ffe289b3e3.mp4";

        [HttpGet("client/1.290.0/src/project.js")]
        public IActionResult GetProjectJs()
        {
            var content = System.IO.File.ReadAllBytes(LOCAL_PROJECT_JS);
            
            Response.Headers.CacheControl = "no-cache, no-store, must-revalidate";
            Response.Headers.Pragma = "no-cache";
            Response.Headers.Expires = "0";
            
            return File(content, "application/javascript; charset=utf-8");
        }

        [HttpGet("deep_one/download_adv/61/52/ac/09/0b28d5f523614f88989ca79def871b2d.txt")]
        public IActionResult GetStory1()
        {
            const string origin = "https://tonofura-r-cdn-client.deepone-online.com";

            if (!System.IO.File.Exists(LOCAL_STORY_TEST))
                return NotFound();

            var bytes = System.IO.File.ReadAllBytes(LOCAL_STORY_TEST);

            // --- CORS (CloudFront-style) ---
            Response.Headers["Access-Control-Allow-Origin"] = origin;
            Response.Headers["Access-Control-Allow-Credentials"] = "true";
            Response.Headers["Access-Control-Allow-Methods"] = "GET";
            Response.Headers["Vary"] = "Origin, Accept-Encoding";

            // --- Caching / metadata ---
            Response.Headers.ETag = "W/\"13e528df58ea35fdfcc39ec1b9a5cb35\"";

            // Optional (disable cache while testing)
            Response.Headers.CacheControl = "no-cache";

            return File(
                bytes,
                "text/plain",
                enableRangeProcessing: true
            );
        }

        [HttpGet("deep_one/download_adv/46/78/b1/b4/dd9acdabf7151ba50e5738ffe289b3e3.mp4")]
        public IActionResult GetMp4Video()
        {
            const string origin = "https://tonofura-r-cdn-client.deepone-online.com";

            if (!System.IO.File.Exists(LOCAL_MP4_PATH))
                return NotFound();

            var bytes = System.IO.File.ReadAllBytes(LOCAL_MP4_PATH);
            var fileLength = bytes.Length;

            // --- CORS (CloudFront-style) ---
            Response.Headers["Access-Control-Allow-Origin"] = origin;
            Response.Headers["Access-Control-Allow-Credentials"] = "true";
            Response.Headers["Access-Control-Allow-Methods"] = "GET";
            Response.Headers["Vary"] = "Origin, Accept-Encoding";

            // --- CloudFront / S3 headers ---
            Response.Headers["Accept-Ranges"] = "bytes";
            Response.Headers["Age"] = "313";
            Response.Headers["Content-Range"] = $"bytes 0-{fileLength - 1}/{fileLength}";
            Response.Headers["ETag"] = "\"aca504e9104df6da3a80521a508fa1e1-2\"";
            Response.Headers["Last-Modified"] = "Tue, 09 Dec 2025 05:17:32 GMT";
            Response.Headers["Server"] = "AmazonS3";
            Response.Headers["Via"] = "1.1 8ec037e7e98aaa67c276ed2ceb33d434.cloudfront.net (CloudFront)";
            Response.Headers["X-Amz-Cf-Id"] = "hv09G3UVZFeuNdR2yO8h7IFBfiEz5HGXc-zp2D1VpwsOluiujp1gkg==";
            Response.Headers["X-Amz-Cf-Pop"] = "KIX82-P1";
            Response.Headers["X-Amz-Server-Side-Encryption"] = "AES256";
            Response.Headers["X-Cache"] = "Hit from cloudfront";

            return File(
                bytes,
                "video/mp4",
                enableRangeProcessing: true
            );
        }
    }
}

