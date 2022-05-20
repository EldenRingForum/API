﻿// <auto-generated />
using System;
using ForumAPI.Areas.WebForum.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumAPI.Areas.WebForum.Migrations
{
    [DbContext(typeof(WebForumContext))]
    [Migration("20220519121112_AddIntroTextSeeding")]
    partial class AddIntroTextSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntroText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Elden Ring General Discussion",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/flask_of_crimson_tears_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Elden Ring Builds",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/crafting_kit_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Elden Ring Community",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/golden_order_seal_sacred_seal_weapon_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Elden Ring Co-op and Help",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/tarnisheds_furled_finger_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Elden Ring Lore",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/conspectus_scroll_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text5"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Elden Ring PvP",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/recusant_finger_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text6"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Elden Ring Support",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/spirit_calling_bell_elden_ring_wiki_guide_200px.png",
                            IntroText = "Hej dette er min intro text7"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Elden Ring Trade",
                            ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/lords-rune-tools-elden-ring-wiki-guide.png",
                            IntroText = "Hej dette er min intro text8"
                        });
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("FlaggedInapropriate")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FlaggedInapropriate = false,
                            PostId = 1,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3484),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            FlaggedInapropriate = false,
                            PostId = 1,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3487),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            FlaggedInapropriate = false,
                            PostId = 1,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3488),
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            FlaggedInapropriate = false,
                            PostId = 2,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3490),
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            FlaggedInapropriate = false,
                            PostId = 2,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3492),
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            FlaggedInapropriate = false,
                            PostId = 1,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3494),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            FlaggedInapropriate = false,
                            PostId = 4,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3496),
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            FlaggedInapropriate = false,
                            PostId = 4,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3498),
                            UserId = 3
                        },
                        new
                        {
                            Id = 9,
                            FlaggedInapropriate = false,
                            PostId = 3,
                            Text = "Imagine using Lorum Ipsum :)",
                            TimeOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3500),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Moderator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Moderators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FlaggedInapropriate")
                        .HasColumnType("bit");

                    b.Property<bool>("Stickied")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3438),
                            FlaggedInapropriate = false,
                            Stickied = false,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c",
                            Title = "MIN TITEL ER DEN BEDSTE",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3467),
                            FlaggedInapropriate = false,
                            Stickied = false,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c",
                            Title = "Den er meget fin",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DateOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3469),
                            FlaggedInapropriate = false,
                            Stickied = false,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c",
                            Title = "Dette build er over powered",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            DateOfCreation = new DateTime(2022, 5, 19, 14, 11, 12, 113, DateTimeKind.Local).AddTicks(3471),
                            FlaggedInapropriate = false,
                            Stickied = false,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c",
                            Title = "Hjælp til første boss",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jegeerenrigtigmail3@mail.com",
                            ProfilePicture = "PFPasString",
                            UserName = "TopDude"
                        },
                        new
                        {
                            Id = 2,
                            Email = "eerenrigtigmail3@mail.com",
                            ProfilePicture = "PFPasString",
                            UserName = "Benitarex"
                        },
                        new
                        {
                            Id = 3,
                            Email = "enrigtigmail3@mail.com",
                            ProfilePicture = "PFPasString",
                            UserName = "MindOfBenita"
                        },
                        new
                        {
                            Id = 4,
                            Email = "jegeerenmail3@mail.com",
                            ProfilePicture = "PFPasString",
                            UserName = "Gamerpigeon"
                        },
                        new
                        {
                            Id = 5,
                            Email = "jegeerenrigtigmail123@mail.com",
                            ProfilePicture = "PFPasString",
                            UserName = "Pigeon Boy"
                        });
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Comment", b =>
                {
                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Moderator", b =>
                {
                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Post", b =>
                {
                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.Category", null)
                        .WithMany("Post")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForumAPI.Areas.WebForum.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Category", b =>
                {
                    b.Navigation("Post");
                });

            modelBuilder.Entity("ForumAPI.Areas.WebForum.Data.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}