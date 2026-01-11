using Microsoft.EntityFrameworkCore;
using AikaSeggs.Database.Models;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database
{
    public class AikaSeggsContext : DbContext
    {
        public DbSet<AccountDB> Accounts { get; set; }
        public DbSet<CharacterDB> Characters { get; set; }

        public AikaSeggsContext(DbContextOptions<AikaSeggsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<CharacterDB>().Property(x => x.Id).ValueGeneratedOnAdd();

            // Account relationships
            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Characters)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserCd)
                .HasPrincipalKey(x => x.UserCd)
                .IsRequired();

            // Unique constraints
            modelBuilder.Entity<CharacterDB>()
                .HasIndex(c => new { c.UserCd, c.CharacterCd })
                .IsUnique();

            // Unique constraint for email
            modelBuilder.Entity<AccountDB>()
                .HasIndex(a => a.Email)
                .IsUnique();
        }
    }
}

