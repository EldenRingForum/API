using ForumAPI.Areas.WebForum.Data.Models;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public bool Stickied { get; set; } = false;
        public bool FlaggedInapropriate { get; set; } = false;
        public List<Comment> Comments { get; set; }
    }
}
