using System.Collections.Generic;

namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class IdentityDTO
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string address { get; set; }
        public List<string> roles { get; set; }
        public bool rememberMe { get; set; }

        public IdentityDTO()
        {
            roles = new List<string>();
        }
    }
}
