﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvidusMerchantAPI.Data;

#nullable disable

namespace ProvidusMerchantAPI.Migrations
{
    [DbContext(typeof(MerchantDBContext))]
    [Migration("20240220132329_First Migration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "a2cb55b0-0c6a-4e24-a774-d2f8c2ab9818",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "ecc6eb08-96ac-46fd-b69c-281ef53bd69a",
                            Name = "regular",
                            NormalizedName = "REGULAR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AccountBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AccountHistoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccountBalance = 5000000m,
                            AccountHistoryId = "1",
                            AccountNumber = "103292891",
                            AccountType = "Current",
                            AppUserId = "1",
                            Pin = 1234
                        });
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.AccountHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Narration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recepient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountHistories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422430),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 2,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422434),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 3,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422437),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 4,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422440),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 5,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422442),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 6,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422446),
                            TransactionType = 1
                        },
                        new
                        {
                            Id = 7,
                            AccountId = "1",
                            AccountName = "Mercator",
                            AccountNumber = "103292891",
                            Amount = 36738,
                            Bank = "Providus",
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Narration = "Funding expense card",
                            Recepient = "Expense card",
                            ReferenceNumber = "#1221",
                            Time = new TimeSpan(518093422448),
                            TransactionType = 1
                        });
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            AccountId = "1",
                            ConcurrencyStamp = "7708bac9-05a3-40f9-a448-84b455424076",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Mercator",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "088e5b5c-5634-4418-976b-bfdd614d2fd4",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Card", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("CardBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CardExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardStatus")
                        .HasColumnType("int");

                    b.Property<int>("CardTypes")
                        .HasColumnType("int");

                    b.Property<string>("Cvv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccountId = "1",
                            CardBalance = 5000m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Nosa Bless",
                            CardNumber = "12921497975725",
                            CardStatus = 0,
                            CardTypes = 0,
                            Cvv = "123"
                        },
                        new
                        {
                            Id = "2",
                            AccountId = "1",
                            CardBalance = 5000m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Eti Bless",
                            CardNumber = "12921497975726",
                            CardStatus = 0,
                            CardTypes = 0,
                            Cvv = "124"
                        },
                        new
                        {
                            Id = "3",
                            AccountId = "1",
                            CardBalance = 6500m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Chike Bless",
                            CardNumber = "12921497975727",
                            CardStatus = 0,
                            CardTypes = 0,
                            Cvv = "125"
                        },
                        new
                        {
                            Id = "5",
                            AccountId = "1",
                            CardBalance = 8500m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Favour Bless",
                            CardNumber = "12921497975727",
                            CardStatus = 0,
                            CardTypes = 0,
                            Cvv = "126"
                        },
                        new
                        {
                            Id = "6",
                            AccountId = "1",
                            CardBalance = 8500m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Chioma Bat",
                            CardNumber = "12921497975728",
                            CardStatus = 1,
                            CardTypes = 0,
                            Cvv = "127"
                        },
                        new
                        {
                            Id = "7",
                            AccountId = "1",
                            CardBalance = 89500m,
                            CardExpiryDate = new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Neo Grace",
                            CardNumber = "12921497975729",
                            CardStatus = 0,
                            CardTypes = 1,
                            Cvv = "128"
                        },
                        new
                        {
                            Id = "8",
                            AccountId = "1",
                            CardBalance = 800m,
                            CardExpiryDate = new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Idris Babs",
                            CardNumber = "12921497975512",
                            CardStatus = 2,
                            CardTypes = 1,
                            Cvv = "023"
                        },
                        new
                        {
                            Id = "9",
                            AccountId = "1",
                            CardBalance = 500m,
                            CardExpiryDate = new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardHolderName = "Uche Wisdom",
                            CardNumber = "12921497975326",
                            CardStatus = 2,
                            CardTypes = 0,
                            Cvv = "012"
                        });
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.CardRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BatchNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardScheme")
                        .HasColumnType("int");

                    b.Property<int>("CardTypes")
                        .HasColumnType("int");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRequest")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("CardRequests");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CardId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CardTransactionStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recipient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CardId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Account", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.AppUser", "AppUser")
                        .WithOne("Account")
                        .HasForeignKey("ProvidusMerchantAPI.Domain.Entities.Account", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.AccountHistory", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.Account", "Account")
                        .WithMany("AccountHistories")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Card", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.Account", "Account")
                        .WithMany("Cards")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.CardRequest", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.Account", "Account")
                        .WithMany("CardRequests")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.Account", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId");

                    b.HasOne("ProvidusMerchantAPI.Domain.Entities.Card", "Card")
                        .WithMany("Transactions")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Account", b =>
                {
                    b.Navigation("AccountHistories");

                    b.Navigation("CardRequests");

                    b.Navigation("Cards");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });

            modelBuilder.Entity("ProvidusMerchantAPI.Domain.Entities.Card", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
