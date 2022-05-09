using ForumAPI.Areas.WebForum.Data.Models;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public bool FlaggedInapropriate { get; set; }
        public List<Comment> Comments { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
