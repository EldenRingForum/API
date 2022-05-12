namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class Moderator
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
