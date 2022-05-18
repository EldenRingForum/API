namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class UserWithPostsAndCommentsDTO
    {
        public User _User { get; set; }
        public List<Post> _Post { get; set; }
        public List<Comment> _Comments { get; set; }
        public UserWithPostsAndCommentsDTO()
        {
            _Post = new List<Post>();
            _Comments = new List<Comment>();
        }
    }
}
