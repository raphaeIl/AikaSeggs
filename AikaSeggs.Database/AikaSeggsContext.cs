using Microsoft.EntityFrameworkCore;
using AikaSeggs.Database.Models;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database
{
    public class AikaSeggsContext : DbContext
    {
        public DbSet<AccountDB> Accounts { get; set; }
        public DbSet<CharacterDB> Characters { get; set; }
        public DbSet<ItemDB> Items { get; set; }
        public DbSet<EquipmentDB> Equipment { get; set; }
        public DbSet<DeckDB> Decks { get; set; }
        public DbSet<MissionDB> Missions { get; set; }
        public DbSet<QuestDB> Quests { get; set; }

        public AikaSeggsContext(DbContextOptions<AikaSeggsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<CharacterDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItemDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<EquipmentDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<DeckDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<MissionDB>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<QuestDB>().Property(x => x.Id).ValueGeneratedOnAdd();

            // Account relationships
            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Characters)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Items)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Equipment)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Decks)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Missions)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            modelBuilder.Entity<AccountDB>()
                .HasMany(x => x.Quests)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.UserId)
                .IsRequired();

            // Unique constraints
            modelBuilder.Entity<CharacterDB>()
                .HasIndex(c => new { c.UserId, c.CharacterCd })
                .IsUnique();

            modelBuilder.Entity<ItemDB>()
                .HasIndex(i => new { i.UserId, i.ItemId })
                .IsUnique();

            modelBuilder.Entity<EquipmentDB>()
                .HasIndex(e => new { e.UserId, e.EquipmentCd })
                .IsUnique();

            modelBuilder.Entity<DeckDB>()
                .HasIndex(d => new { d.UserId, d.DeckId })
                .IsUnique();

            modelBuilder.Entity<MissionDB>()
                .HasIndex(m => new { m.UserId, m.MissionId })
                .IsUnique();

            modelBuilder.Entity<QuestDB>()
                .HasIndex(q => new { q.UserId, q.QuestId })
                .IsUnique();

            // Unique constraint for email
            modelBuilder.Entity<AccountDB>()
                .HasIndex(a => a.Email)
                .IsUnique();
        }
    }
}

