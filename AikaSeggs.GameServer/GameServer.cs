using AikaSeggs.Common;
using AikaSeggs.Common.Services;
using AikaSeggs.Database;
using AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;
using System.Threading.Tasks;

namespace AikaSeggs.GameServer
{
    public class GameServer
    {
        public static void Main(string[] args)
        {
            Log.Information("Starting Game Server...");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                // Configure Kestrel to listen on PORT environment variable (for Railway/cloud platforms)
                var port = Environment.GetEnvironmentVariable("PORT");
                if (!string.IsNullOrEmpty(port) && int.TryParse(port, out var portNumber))
                {
                    builder.WebHost.ConfigureKestrel(options =>
                    {
                        options.ListenAnyIP(portNumber);
                    });
                    Log.Information("Configured Kestrel to listen on PORT: {Port}", portNumber);
                }

                builder.Services.Configure<KestrelServerOptions>(op =>
                    op.AllowSynchronousIO = true
                );
                
                // Configure Serilog to read from configuration and ensure console output
                builder.Host.UseSerilog((context, services, configuration) => 
                    configuration
                        .ReadFrom.Configuration(context.Configuration)
                        .Enrich.FromLogContext()
                        .WriteTo.Console(
                            outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                );

                builder.Services.AddControllers();
                builder.Services.AddHealthChecks();
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
                
                // Log that server is about to start
                var serverPort = Environment.GetEnvironmentVariable("PORT");
                Log.Information("Starting web server on port: {Port}", serverPort ?? "default");
                
                // Start background tasks after server is ready
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await Task.Delay(2000); // Give server time to start
                        Log.Information("Loading PCAP packets...");
                        PcapParser.PcapParser.Instance.LoadAllPackets();
                        
                        Log.Information("Downloading master data tables...");
                        var success = ResourceService.DownloadAllMasterData();
                        if (!success)
                        {
                            Log.Warning("Resource download failed or incomplete");
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "Error in background initialization tasks");
                    }
                });
                
                Log.Information("Web server starting...");
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
