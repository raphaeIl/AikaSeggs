using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AikaSeggs.Database
{
    public class AikaSeggsContextFactory : IDesignTimeDbContextFactory<AikaSeggsContext>
    {
        public AikaSeggsContext CreateDbContext(string[] args)
        {
            // Find appsettings.json in GameServer project
            var basePath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory())!.FullName,
                "AikaSeggs.GameServer"
            );

            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("SqliteConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'SqliteConnection' not found in appsettings.json");
            }

            // Resolve database path
            var dbPath = connectionString.Replace("Data Source=", "").Trim();
            if (!Path.IsPathRooted(dbPath))
            {
                // For design-time, use the GameServer bin directory as base
                var configPath = Path.Combine(basePath, "bin", "Debug", "net8.0");
                dbPath = Path.Combine(configPath, dbPath);
            }

            var optionsBuilder = new DbContextOptionsBuilder<AikaSeggsContext>();
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new AikaSeggsContext(optionsBuilder.Options);
        }
    }
}

