using Microsoft.EntityFrameworkCore;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
