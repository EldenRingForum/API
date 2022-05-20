namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class PostWithCategoryDTO
    {
        public Post Post { get; set; }
        public Category Category { get; set; }
        public int CommentAmount { get; set; }
        public string TimeOfCreation { get; set; }
    }
}
