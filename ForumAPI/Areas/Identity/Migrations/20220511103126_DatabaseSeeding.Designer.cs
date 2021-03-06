// <auto-generated />
using System;
using ForumAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumAPI.Areas.Identity.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20220511103126_DatabaseSeeding")]
    partial class DatabaseSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
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
                            Id = "d950013d-971c-45f3-907b-bf282f37359f",
                            ConcurrencyStamp = "1",
                            Name = "USER",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "66cf8789-99dc-4e8a-a163-3c6d924e8efe",
                            ConcurrencyStamp = "2",
                            Name = "MODERATOR",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "9d3d19bc-efdd-4791-a967-7ce36e2a7061",
                            ConcurrencyStamp = "3",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "74379d0f-1055-4a73-ab60-d972dc91518a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1f131b1e-ce5d-4e0e-97e8-d6bc77f132d4",
                            Email = "jegeerenrigtigmail3@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JEGEERENRIGTIGMAIL3@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIUY8cEB2u45f/RcYxVVY6J1BQMZ31q9i6WIdcEYz5NkT+sUtxZO+sK3YQYH4ShX4g==",
                            PhoneNumber = "+111111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c0533172-8fcd-4037-8def-5d04b4d6bd65",
                            TwoFactorEnabled = false,
                            UserName = "Vraksi"
                        },
                        new
                        {
                            Id = "ec66faf9-f096-47b1-8934-9e9c4746ebb1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "45a3c506-26b4-4a22-89e3-15d2c17df63b",
                            Email = "eerenrigtigmail3@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EERENRIGTIGMAIL3@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIilKH9AVHbpzfkWk1EJMdZkbkp+WM8SopIhDh+4nitPDDMWpF+WvhfyrxlynLzFew==",
                            PhoneNumber = "+111111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a5c6bb08-50f7-44af-9841-4661865dcb5f",
                            TwoFactorEnabled = false,
                            UserName = "Benitarex"
                        },
                        new
                        {
                            Id = "76bb83fe-ff31-4f1b-8884-cefb30e0c552",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2dfc644c-8e4d-46d4-900b-b3fd024b3feb",
                            Email = "enrigtigmail3@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ENRIGTIGMAIL3@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIoTI8R+K4J6U90LJRpBo5HyisboqFRjMdz8yvJDc4lTMpJ6xWOSJRO7iPQXCyj7rA==",
                            PhoneNumber = "+111111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "77bf27db-c1fd-4436-827f-aa0b42f7b086",
                            TwoFactorEnabled = false,
                            UserName = "MindOfBenita"
                        },
                        new
                        {
                            Id = "8af154e9-fb65-41ab-96ef-4f47775c32a7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3fd898bc-3a70-401c-abc8-419b5a7eb77f",
                            Email = "jegeerenmail3@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JEGEERENMAIL3@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHStYSlBv02HIlWZr3mHW8dYxk9Wtu0sAKKm87KbMFdhENwfegqLXAxHi5HZ0kpJag==",
                            PhoneNumber = "+111111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d2c30cb2-7d50-4f04-a62f-875a65c85e63",
                            TwoFactorEnabled = false,
                            UserName = "Gamerpigeon"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "74379d0f-1055-4a73-ab60-d972dc91518a",
                            RoleId = "d950013d-971c-45f3-907b-bf282f37359f"
                        },
                        new
                        {
                            UserId = "74379d0f-1055-4a73-ab60-d972dc91518a",
                            RoleId = "66cf8789-99dc-4e8a-a163-3c6d924e8efe"
                        },
                        new
                        {
                            UserId = "ec66faf9-f096-47b1-8934-9e9c4746ebb1",
                            RoleId = "d950013d-971c-45f3-907b-bf282f37359f"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
