using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProvidusMerchantAPI.Domain.Entities;
using ProvidusMerchantAPI.Domain.Enums;

namespace ProvidusMerchantAPI.Data
{
    public class MerchantDBContext : IdentityDbContext<AppUser>
    {
        public MerchantDBContext(DbContextOptions<MerchantDBContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardRequest> CardRequests { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountHistory> AccountHistories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "regular", NormalizedName = "REGULAR" }
            );

            modelBuilder.Entity<Account>()
                .HasOne(a => a.AppUser)
                .WithOne(u => u.Account)
                .HasForeignKey<Account>(a => a.AppUserId);

            modelBuilder.Entity<Account>()
                .HasMany(a => a.AccountHistories)
                .WithOne(h => h.Account)
                .HasForeignKey(h => h.AccountId);
            
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Cards)
                .WithOne(h => h.Account)
                .HasForeignKey(h => h.AccountId);



            // Seed Account data
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "1",
                    Name = "Mercator",
                    AccountId = "1", 
                }
            );

            // Seed Account data
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = "1",
                    AccountNumber = "103292891",
                    AccountBalance = 5000000, 
                    AccountType = "Current",
                    Pin = 1234, 
                    AppUserId = "1",
                    AccountHistoryId = "1"
                }
            );


            // Seed AccountHistory data
            modelBuilder.Entity<AccountHistory>().HasData(
                new AccountHistory
                {
                    Id = 1,
                    AccountId = "1", 
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 2,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 3,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 4,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 5,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 6,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                },
                new AccountHistory
                {
                    Id = 7,
                    AccountId = "1",
                    ReferenceNumber = "#1221",
                    AccountName = "Mercator",
                    Amount = 36738,
                    Recepient = "Expense card",
                    AccountNumber = "103292891",
                    Narration = "Funding expense card",
                    Date = DateTime.Now.Date,
                    Time = DateTime.Now.TimeOfDay,
                    TransactionType = TransactionType.Outcome,
                    Bank = "Providus"
                }
            );

            modelBuilder.Entity<Card>().HasData(
                new Card
                {
                    Id = "1",
                    CardHolderName = "Nosa Bless",
                    CardNumber = "12921497975725",
                    Cvv = "123",
                    CardBalance = 5000,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.Activated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "2",
                    CardHolderName = "Eti Bless",
                    CardNumber = "12921497975726",
                    Cvv = "124",
                    CardBalance = 5000,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.Activated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "3",
                    CardHolderName = "Chike Bless",
                    CardNumber = "12921497975727",
                    Cvv = "125",
                    CardBalance = 6500,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.Activated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "5",
                    CardHolderName = "Favour Bless",
                    CardNumber = "12921497975727",
                    Cvv = "126",
                    CardBalance = 8500,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.Activated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "6",
                    CardHolderName = "Chioma Bat",
                    CardNumber = "12921497975728",
                    Cvv = "127",
                    CardBalance = 8500,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.NotActivated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "7",
                    CardHolderName = "Neo Grace",
                    CardNumber = "12921497975729",
                    Cvv = "128",
                    CardBalance = 89500,
                    CardExpiryDate = DateTime.Parse("2026-11-28"),
                    CardTypes = CardType.Physical,
                    CardStatus = CardStatus.Activated,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "8",
                    CardHolderName = "Idris Babs",
                    CardNumber = "12921497975512",
                    Cvv = "023",
                    CardBalance = 800,
                    CardExpiryDate = DateTime.Parse("2024-01-30"),
                    CardTypes = CardType.Physical,
                    CardStatus = CardStatus.Expired,
                    AccountId = "1",
                },
                new Card
                {
                    Id = "9",
                    CardHolderName = "Uche Wisdom",
                    CardNumber = "12921497975326",
                    Cvv = "012",
                    CardBalance = 500,
                    CardExpiryDate = DateTime.Parse("2023-01-30"),
                    CardTypes = CardType.Virtual,
                    CardStatus = CardStatus.Expired,
                    AccountId = "1",
                }
                );
        }
    }
}
