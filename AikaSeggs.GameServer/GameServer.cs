using AikaSeggs.Common;
using AikaSeggs.Common.Services;
using AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;
using System.Reflection;

namespace AikaSeggs.GameServer
{
    public class GameServer
    {
        public static void Main(string[] args)
        {
            Log.Information("Starting Game Server...");

            // Load PCAP packets
            PcapParser.PcapParser.Instance.LoadAllPackets();

            // Download master data tables
            var success = ResourceService.DownloadAllMasterData();
            if (!success)
            {
                Log.Warning("Resource download failed or incomplete");
            }

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.Configure<KestrelServerOptions>(op =>
                    op.AllowSynchronousIO = true
                );
                builder.Host.UseSerilog();

                builder.Services.AddControllers();
                builder.Services.AddProtocolHandlerFactory();
                builder.Services.AddControllers().AddApplicationPart(Assembly.GetAssembly(typeof(GameServer)));
                builder.Services.AddTableService();

                var handlerGroups = Assembly.GetAssembly(typeof(ProtocolHandlerFactory))
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(ProtocolHandlerBase)));

                foreach (var handlerGroup in handlerGroups)
                {
                    builder.Services.AddProtocolHandlerGroupByType(handlerGroup);
                }

                var app = builder.Build();

                app.UseAuthorization();
                app.UseSerilogRequestLogging();

                app.MapControllers();
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled exception occurred during runtime");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
