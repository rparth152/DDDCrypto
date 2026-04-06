using CryptoWebAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoWebAPI.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        // -----------------------------
        // DbSets
        // -----------------------------
        public DbSet<UserMaster> Users { get; set; }
        public DbSet<WalletMaster> Wallets { get; set; }
        public DbSet<CryptoMaster> Cryptos { get; set; }
        public DbSet<UserPortfolio> Portfolios { get; set; }
        public DbSet<TransactionHistory> Transactions { get; set; }
        public DbSet<WalletTransaction> WalletTransactions { get; set; }
        public DbSet<UserFav> Favorites { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Setting> Settings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //---------------------------------------------------------
            // WalletMaster Relationships
            //---------------------------------------------------------

            // Wallet Owner
            modelBuilder.Entity<WalletMaster>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wallets)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            //---------------------------------------------------------
            // WalletTransaction Relationships
            //---------------------------------------------------------

            modelBuilder.Entity<WalletTransaction>()
                .HasOne(t => t.Wallet)
                .WithMany(w => w.WalletTransactions)
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WalletTransaction>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            //---------------------------------------------------------
            // Currency → CryptoMaster
            //---------------------------------------------------------

            modelBuilder.Entity<Currency>()
                .HasMany(c => c.Cryptos)
                .WithOne(c => c.Currency)
                .HasForeignKey(c => c.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);


            //---------------------------------------------------------
            // CryptoMaster Relationships
            //---------------------------------------------------------

            modelBuilder.Entity<CryptoMaster>()
                .HasOne(c => c.Currency)
                .WithMany(c => c.Cryptos)
                .HasForeignKey(c => c.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            //---------------------------------------------------------
            // UserPortfolio Relationships
            //---------------------------------------------------------

            modelBuilder.Entity<UserPortfolio>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserPortfolio>()
                .HasOne(p => p.Crypto)
                .WithMany()
                .HasForeignKey(p => p.CryptoId)
                .OnDelete(DeleteBehavior.Restrict);


            //---------------------------------------------------------
            // TransactionHistory Relationships
            //---------------------------------------------------------

            modelBuilder.Entity<TransactionHistory>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransactionHistory>()
                .HasOne(t => t.Wallet)
                .WithMany()
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransactionHistory>()
                .HasOne(t => t.Crypto)
                .WithMany()
                .HasForeignKey(t => t.CryptoId)
                .OnDelete(DeleteBehavior.Restrict);


            //---------------------------------------------------------
            // UserFav Relationships
            //---------------------------------------------------------

            modelBuilder.Entity<UserFav>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFav>()
                .HasOne(f => f.Crypto)
                .WithMany()
                .HasForeignKey(f => f.CryptoId)
                .OnDelete(DeleteBehavior.Restrict);

            //---------------------------------------------------------
            // Setting Relationships (One-To-One with User)
            //---------------------------------------------------------

            modelBuilder.Entity<Setting>()
                .HasOne(s => s.User)
                .WithOne()
                .HasForeignKey<Setting>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}