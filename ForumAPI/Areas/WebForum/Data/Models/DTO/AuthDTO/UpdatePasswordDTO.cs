namespace ForumAPI.Areas.WebForum.Data.Models.DTO.AuthDTO
{
    public class UpdatePasswordDTO
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
