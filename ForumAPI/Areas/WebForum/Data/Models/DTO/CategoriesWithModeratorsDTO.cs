namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class CategoriesWithModeratorsDTO
    {
        public List<User> Users { get; set; }
        public Category Category { get; set; }
        public CategoriesWithModeratorsDTO()
        {
            Users = new List<User>();
        }
    }
}
