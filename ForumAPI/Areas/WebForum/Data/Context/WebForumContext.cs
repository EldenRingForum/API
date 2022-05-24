using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ForumAPI.Areas.WebForum.Data.Context
{
    public class WebForumContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Moderator> Moderators { get; set; }

        public WebForumContext(DbContextOptions<WebForumContext> options)
            : base(options)
        {

            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Ignore(s => s.CommentAmount);
            modelBuilder.Entity<User>().HasIndex(s => s.UserName).IsUnique();
            modelBuilder.Entity<User>().Property(s => s.ProfilePicture).HasDefaultValue("https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg");
            SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "TopDude", Email = "jegeerenrigtigmail3@mail.com" },
                new User { Id = 2, UserName = "Benitarex", Email = "eerenrigtigmail3@mail.com" },
                new User { Id = 3, UserName = "MindOfBenita", Email = "enrigtigmail3@mail.com" },
                new User { Id = 4, UserName = "Gamerpigeon", Email = "jegeerenmail3@mail.com" },
                new User { Id = 5, UserName = "Pigeon Boy", Email = "jegeerenrigtigmail123@mail.com" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, IntroText = "Hej dette er min intro text1", CategoryName = "General Discussion", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/flask_of_crimson_tears_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 2, IntroText = "Hej dette er min intro text2", CategoryName = "Builds", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/crafting_kit_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 3, IntroText = "Hej dette er min intro text3", CategoryName = "Community", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/golden_order_seal_sacred_seal_weapon_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 4, IntroText = "Hej dette er min intro text4", CategoryName = "Co-op and Help", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/tarnisheds_furled_finger_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 5, IntroText = "Hej dette er min intro text5", CategoryName = "Lore", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/conspectus_scroll_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 6, IntroText = "Hej dette er min intro text6", CategoryName = "PvP", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/recusant_finger_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 7, IntroText = "Hej dette er min intro text7", CategoryName = "Support", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/spirit_calling_bell_elden_ring_wiki_guide_200px.png" },
                new Category { Id = 8, IntroText = "Hej dette er min intro text8", CategoryName = "Trade", ImageLink = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/lords-rune-tools-elden-ring-wiki-guide.png" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, CategoryId = 1, UserId = 1, Title = "MIN TITEL ER DEN BEDSTE", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", DateOfCreation = DateTime.Now },
                new Post { Id = 2, CategoryId = 1, UserId = 1, Title = "Den er meget fin", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", DateOfCreation = DateTime.Now },
                new Post { Id = 3, CategoryId = 2, UserId = 2, Title = "Dette build er over powered", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", DateOfCreation = DateTime.Now },
                new Post { Id = 4, CategoryId = 4, UserId = 3, Title = "Hjælp til første boss", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel nunc ante. Fusce id nisl venenatis, mattis massa ut, laoreet velit. Vestibulum et est a diam rhoncus cursus non quis ipsum. Cras dignissim at massa ac finibus. Aenean non odio sed nisi ultrices ultrices vitae mollis risus. Quisque eleifend, leo quis consectetur placerat, mauris dolor congue quam, sit amet gravida augue quam quis augue. Maecenas et pulvinar ipsum. Sed lobortis vestibulum dolor vel rhoncus. Vestibulum non venenatis sapien, non blandit augue. Vivamus tortor libero, viverra ac vestibulum vel, c", DateOfCreation = DateTime.Now }
                );
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, UserId = 1, PostId = 1, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 2, UserId = 1, PostId = 1, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 3, UserId = 2, PostId = 1, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 4, UserId = 2, PostId = 2, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 5, UserId = 3, PostId = 2, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 6, UserId = 1, PostId = 1, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 7, UserId = 3, PostId = 4, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 8, UserId = 3, PostId = 4, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now },
                new Comment { Id = 9, UserId = 3, PostId = 3, Text = "Imagine using Lorum Ipsum :)", TimeOfCreation = DateTime.Now }
                );
            modelBuilder.Entity<Moderator>().HasData(
                new Moderator { Id = 1, UserId = 1, CategoryId = 1 },
                new Moderator { Id = 2, UserId = 1, CategoryId = 2 },
                new Moderator { Id = 3, UserId = 2, CategoryId = 3 },
                new Moderator { Id = 4, UserId = 3, CategoryId = 3 }
                );
        }
    }
}
