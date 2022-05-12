namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class CommentsWithUserDTO
    {
        public User User { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
