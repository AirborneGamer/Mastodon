﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OsOEasy.Data;

namespace OsOEasy.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180810043938_addSideOfScreen2")]
    partial class addSideOfScreen2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("AccountCreationDate");

                    b.Property<bool>("AccountSuspended");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfLastPromoClaim");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsNewUser");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<bool>("MonthlyPromotionLimitReached");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("PromoClaimsForCurrentMonth");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StripeCustomerId");

                    b.Property<string>("SubscriptionPlan");

                    b.Property<int>("TimesLoggedIn");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("UserPromoScript");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.PaymentActivity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUser");

                    b.Property<bool>("MonthlyPlanPayment");

                    b.Property<decimal>("PaymentAmount");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<string>("PaymentNotes");

                    b.Property<bool>("SpecialPurchase");

                    b.Property<string>("SpecialPurchaseItem");

                    b.HasKey("Id");

                    b.ToTable("PaymentActivity");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.Promotion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ActivePromotion");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("ButtonColor");

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Details1");

                    b.Property<string>("Details2");

                    b.Property<string>("Discount");

                    b.Property<string>("DisplayEndDate");

                    b.Property<string>("EndDate");

                    b.Property<string>("FinePrint");

                    b.Property<string>("ImageName");

                    b.Property<string>("ImageType");

                    b.Property<bool>("ShowCouponBorder");

                    b.Property<bool>("ShowLargeImage");

                    b.Property<string>("SideOfScreen");

                    b.Property<string>("ThankYouMessage");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.PromotionEntries", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name");

                    b.Property<string>("PromotionId");

                    b.HasKey("Id");

                    b.HasIndex("PromotionId");

                    b.ToTable("PromotionEntries");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.PromotionStats", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PromotionId");

                    b.Property<int>("TimesClaimed");

                    b.Property<int>("TimesViewed");

                    b.HasKey("Id");

                    b.HasIndex("PromotionId");

                    b.ToTable("PromotionStats");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.SocialSharing", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ActivePromotion");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("FacebookImageName");

                    b.Property<string>("FacebookImageType");

                    b.Property<string>("FacebookURL");

                    b.Property<string>("InstagramImageName");

                    b.Property<string>("InstagramImageType");

                    b.Property<string>("InstagramURL");

                    b.Property<string>("LinkedinImageName");

                    b.Property<string>("LinkedinImageType");

                    b.Property<string>("LinkedinURL");

                    b.Property<string>("PinterestImageName");

                    b.Property<string>("PinterestImageType");

                    b.Property<string>("PinterestURL");

                    b.Property<string>("SideOfScreen");

                    b.Property<string>("Title");

                    b.Property<string>("TwitterImageName");

                    b.Property<string>("TwitterImageType");

                    b.Property<string>("TwitterURL");

                    b.Property<bool>("UseFacebook");

                    b.Property<bool>("UseInstagram");

                    b.Property<bool>("UseLinkedin");

                    b.Property<bool>("UsePinterest");

                    b.Property<bool>("UseTwitter");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("SocialSharing");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OsOEasy.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OsOEasy.Data.Models.Promotion", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.PromotionEntries", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.PromotionStats", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId");
                });

            modelBuilder.Entity("OsOEasy.Data.Models.SocialSharing", b =>
                {
                    b.HasOne("OsOEasy.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
