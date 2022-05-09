using ForumAPI.Areas.WebForum.Data.Context;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
