 using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace AikaSeggs.GameServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class GameController : ControllerBase
    {
        [Route("getConfig")]
        public IResult GetConfig()
        {
            return Results.Text(@"");
        }

        [HttpGet("{*catchAll}")]
        public IResult CatchAllGet(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpPost("{*catchAll}")]
        public IResult CatchAllPost(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpOptions("{*catchAll}")]
        public IActionResult CatchAllOptions(string catchAll)
        {
            Log.Information($"HttpOptions: {catchAll}");
            
            // Set all required headers
            Response.Headers.Append("Access-Control-Allow-Credentials", "true");
            Response.Headers.Append("X-DNS-Prefetch-Control", "off");
            Response.Headers.Append("X-Frame-Options", "SAMEORIGIN");
            Response.Headers.Append("Strict-Transport-Security", "max-age=15552000; includeSubDomains");
            Response.Headers.Append("X-Download-Options", "noopen");
            Response.Headers.Append("X-Content-Type-Options", "nosniff");
            Response.Headers.Append("X-XSS-Protection", "1; mode=block");
            Response.Headers.Append("Access-Control-Allow-Origin", "*");
            Response.Headers.Append("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept, Authorization, X-Deep-One-App-Version");
            Response.Headers.Append("Allow", "GET,HEAD");
            Response.Headers.Append("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
            
            return Content("GET,HEAD", "text/html; charset=utf-8");
        }
    }
}

