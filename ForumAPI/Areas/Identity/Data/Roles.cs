namespace ForumAPI.Areas.Identity.Data
{
    public class Roles
    {
        private const string Role1 = "USER";
        private const string Role2 = "MODERATOR";
        private const string Role3 = "ADMIN";

        public List<string> roles { get; set; }

        public Roles()
        {
            roles = new List<string>();
            roles.Add(Role1);
            roles.Add(Role2);
            roles.Add(Role3);
        }
    }
}
