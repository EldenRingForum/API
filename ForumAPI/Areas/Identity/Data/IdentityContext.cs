using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ForumAPI.Data;

public class IdentityContext : IdentityDbContext<IdentityUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<IdentityUser>().HasIndex(s => s.UserName).IsUnique();
        Seed(builder);
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    private void Seed(ModelBuilder builder)
    {
        PasswordHasher<IdentityUser> password = new PasswordHasher<IdentityUser>();
        IdentityUser user = new IdentityUser
        {
            Id = "74379d0f-1055-4a73-ab60-d972dc91518a",
            UserName = "Vraksi",
            Email = "jegeerenrigtigmail3@mail.com",
            NormalizedEmail = "JEGEERENRIGTIGMAIL3@MAIL.COM",
            PhoneNumber = "+111111111111",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };
        IdentityUser user1 = new IdentityUser
        {
            Id = "ec66faf9-f096-47b1-8934-9e9c4746ebb1",
            UserName = "Benitarex",
            Email = "eerenrigtigmail3@mail.com",
            NormalizedEmail = "EERENRIGTIGMAIL3@MAIL.COM",
            PhoneNumber = "+111111111111",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };
        IdentityUser user2 = new IdentityUser
        {
            Id = "76bb83fe-ff31-4f1b-8884-cefb30e0c552",
            UserName = "MindOfBenita",
            Email = "enrigtigmail3@mail.com",
            NormalizedEmail = "ENRIGTIGMAIL3@MAIL.COM",
            PhoneNumber = "+111111111111",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };
        IdentityUser user3 = new IdentityUser
        {
            Id = "8af154e9-fb65-41ab-96ef-4f47775c32a7",
            UserName = "Gamerpigeon",
            Email = "jegeerenmail3@mail.com",
            NormalizedEmail = "JEGEERENMAIL3@MAIL.COM",
            PhoneNumber = "+111111111111",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };


        user.PasswordHash = password.HashPassword(user, "@Sikkertpassword123");
        user1.PasswordHash = password.HashPassword(user1, "@Sikkertpassword123");
        user2.PasswordHash = password.HashPassword(user2, "@Sikkertpassword123");
        user3.PasswordHash = password.HashPassword(user3, "@Sikkertpassword123");
        
        builder.Entity<IdentityUser>().HasData(
                user,
                user1,
                user2,
                user3
            );

        builder.Entity<IdentityRole>().HasData(
           new IdentityRole()
           {
               Id = "d950013d-971c-45f3-907b-bf282f37359f",
               Name = "USER",
               ConcurrencyStamp = "1", 
               NormalizedName = "USER"
           },
           new IdentityRole()
           {
               Id = "66cf8789-99dc-4e8a-a163-3c6d924e8efe",
               Name = "MODERATOR",
               ConcurrencyStamp = "2",
               NormalizedName = "MODERATOR"
           },
           new IdentityRole()
           {
               Id = "9d3d19bc-efdd-4791-a967-7ce36e2a7061",
               Name = "ADMIN",
               ConcurrencyStamp = "3",
               NormalizedName = "ADMIN"
           }
           );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                RoleId = "d950013d-971c-45f3-907b-bf282f37359f",
                UserId = "74379d0f-1055-4a73-ab60-d972dc91518a"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "66cf8789-99dc-4e8a-a163-3c6d924e8efe",
                UserId = "74379d0f-1055-4a73-ab60-d972dc91518a"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "d950013d-971c-45f3-907b-bf282f37359f",
                UserId = "ec66faf9-f096-47b1-8934-9e9c4746ebb1"
            }

            );

    }
}
