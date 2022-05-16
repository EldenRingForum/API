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
            modelBuilder.Entity<User>().HasIndex(s => s.UserName).IsUnique();
            SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "TopDude", ProfilePicture = "PFPasString", Email = "jegeerenrigtigmail3@mail.com" },
                new User { Id = 2, UserName = "Benitarex", ProfilePicture = "PFPasString", Email = "eerenrigtigmail3@mail.com" },
                new User { Id = 3, UserName = "MindOfBenita", ProfilePicture = "PFPasString", Email = "enrigtigmail3@mail.com" },
                new User { Id = 4, UserName = "Gamerpigeon", ProfilePicture = "PFPasString", Email = "jegeerenmail3@mail.com" },
                new User { Id = 5, UserName = "Pigeon Boy", ProfilePicture = "PFPasString", Email = "jegeerenrigtigmail123@mail.com" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Elden Ring General Diskussion" },
                new Category { Id = 2, CategoryName = "Elden Ring Builds"},
                new Category { Id = 3, CategoryName = "Elden Ring Community"},
                new Category { Id = 4, CategoryName = "Elden Ring Lore" },
                new Category { Id = 5, CategoryName = "Elden Ring Co-op and Help" },
                new Category { Id = 6, CategoryName = "Elden Ring PvP"},
                new Category { Id = 7, CategoryName = "Elden Ring Support"},
                new Category { Id = 8, CategoryName = "Elden Ring Trade"}
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
