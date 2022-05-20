namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class UnpinnedAndPinnedPostsDTO
    {
        public List<Post> UnpinnedPosts { get; set; }
        public List<Post> PinnedPosts { get; set; }
        public int CommentAmount { get; set; }
        public UnpinnedAndPinnedPostsDTO()
        {
            PinnedPosts = new List<Post>();
            UnpinnedPosts = new List<Post>();
        }
    }
}
