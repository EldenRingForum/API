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
            SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Vraksi", ProfilePicture = "PFPasString", Email = "jegeerenrigtigmail3@mail.com" },
                new User { Id = 2, UserName = "Vraksi", ProfilePicture = "PFPasString", Email = "eerenrigtigmail3@mail.com" },
                new User { Id = 3, UserName = "Vraksi", ProfilePicture = "PFPasString", Email = "enrigtigmail3@mail.com" },
                new User { Id = 4, UserName = "Vraksi", ProfilePicture = "PFPasString", Email = "jegeerenmail3@mail.com" },
                new User { Id = 5, UserName = "Vraksi", ProfilePicture = "PFPasString", Email = "jegeerenrigtigmail123@mail.com" }
                );
        }
    }
}
