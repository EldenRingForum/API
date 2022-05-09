using ForumAPI.Areas.WebForum.Data.Context;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public bool FlaggedInapropriate { get; set; }
        public User User { get; set; }

        public Comment()
        {

        }
    }
}
