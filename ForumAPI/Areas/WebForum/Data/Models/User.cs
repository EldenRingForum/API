using Microsoft.EntityFrameworkCore;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; } = "https://i.pinimg.com/736x/74/b3/54/74b35486d3a1f639519ba0cf12821016.jpg";
        public string Email { get; set; }

    }
}
