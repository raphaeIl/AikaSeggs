using AikaSeggs.Common;
using AikaSeggs.Common.Services;
using AikaSeggs.Database;
using AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
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
                var gameServerAssembly = Assembly.GetAssembly(typeof(GameServer));
                if (gameServerAssembly != null)
                {
                    builder.Services.AddControllers().AddApplicationPart(gameServerAssembly);
                }
                builder.Services.AddTableService();

                // SQLite database
                var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
                if (!string.IsNullOrEmpty(connectionString))
                {
                    // Extract path from connection string (e.g., "Data Source=Resources/Data/AikaSeggs.db")
                    var dbPath = connectionString.Replace("Data Source=", "").Trim();
                    if (!Path.IsPathRooted(dbPath))
                    {
                        // Resolve relative path
                        var basePath = Path.GetDirectoryName(AppContext.BaseDirectory) ?? Directory.GetCurrentDirectory();
                        dbPath = Path.Combine(basePath, dbPath);
                    }
                    
                    // Ensure directory exists
                    var dbDirectory = Path.GetDirectoryName(dbPath);
                    if (!string.IsNullOrEmpty(dbDirectory) && !Directory.Exists(dbDirectory))
                    {
                        Directory.CreateDirectory(dbDirectory);
                        Log.Information("Created database directory: {Directory}", dbDirectory);
                    }
                    
                    builder.Services.AddDbContext<AikaSeggsContext>(options => 
                        options.UseSqlite($"Data Source={dbPath}"));
                }

                var protocolHandlerAssembly = Assembly.GetAssembly(typeof(ProtocolHandlerFactory));
                if (protocolHandlerAssembly != null)
                {
                    var handlerGroups = protocolHandlerAssembly
                        .GetTypes()
                        .Where(t => t.IsSubclassOf(typeof(ProtocolHandlerBase)));

                    foreach (var handlerGroup in handlerGroups)
                    {
                        builder.Services.AddProtocolHandlerGroupByType(handlerGroup);
                    }
                }

                var app = builder.Build();

                // Apply migrations on startup
                try
                {
                    using (var scope = app.Services.CreateScope())
                    {
                        var context = scope.ServiceProvider.GetRequiredService<AikaSeggsContext>();
                        context.Database.Migrate();
                        Log.Information("Database migrations applied");
                    }
                }
                catch (Exception ex)
                {
                    Log.Warning(ex, "Failed to apply database migrations. Make sure migrations exist.");
                }

                app.UseHealthChecks("/health");
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
