using ForumAPI.Areas.WebForum.Data.Context;
using System.Collections.Generic;

namespace ForumAPI.Areas.WebForum.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string IntroText { get; set; }
        public List<Post> Post { get; set; }


    }
}
