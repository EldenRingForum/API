using System.Collections.Generic;

namespace ForumAPI.Areas.WebForum.Data.Models.DTO
{
    public class IdentityDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public List<string> roles { get; set; }
        public bool RememberMe { get; set; }

        public IdentityDTO()
        {
            roles = new List<string>();
        }
    }
}
