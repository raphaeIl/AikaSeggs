using Microsoft.EntityFrameworkCore;
using AikaSeggs.Database.Models;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AikaSeggs.Database
{
    public class AikaSeggsContext : DbContext
    {
        public DbSet<AccountDB> Accounts { get; set; }
        public DbSet<CharacterDB> Characters { get; set; }
        public DbSet<StoryDB> Stories { get; set; }
        public DbSet<PictureBookDB> PictureBooks { get; set; }

        public AikaSeggsContext(DbContextOptions<AikaSeggsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<CharacterDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<StoryDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<PictureBookDB>().Property(x => x.Id).ValueGeneratedOnAdd();

            // Account relationships
            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Characters)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserCd)
                .HasPrincipalKey(x => x.UserCd)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Stories)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserCd)
                .HasPrincipalKey(x => x.UserCd)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.PictureBooks)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserCd)
                .HasPrincipalKey(x => x.UserCd)
                .IsRequired();

            // Unique constraints
            modelBuilder.Entity<CharacterDB>()
                .HasIndex(c => new { c.UserCd, c.CharacterCd })
                .IsUnique();

            modelBuilder.Entity<StoryDB>()
                .HasIndex(s => new { s.UserCd, s.StoryId })
                .IsUnique();

            modelBuilder.Entity<PictureBookDB>()
                .HasIndex(p => new { p.UserCd, p.CharacterId })
                .IsUnique();

            // Unique constraint for email
            modelBuilder.Entity<AccountDB>()
                .HasIndex(a => a.Email)
                .IsUnique();
        }
    }
}

