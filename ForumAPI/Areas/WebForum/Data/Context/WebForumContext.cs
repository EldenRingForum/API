using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
