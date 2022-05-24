using ForumAPI.Areas.Identity.Services;
using ForumAPI.Areas.WebForum.Data.Context;
using ForumAPI.Areas.WebForum.Data.Models.DTO;
using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ForumAPI.Areas.WebForum.Data.Models.DTO.AuthDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Areas.WebForum.Controllers.EntryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IdentityHandler _identityHandler;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _cookieName;
        private readonly WebForumContext _context;


        public IdentityController(
            WebForumContext context,
            IdentityHandler identityHandler,
            IConfiguration configuration
            )
        {
            _context = context;
            _identityHandler = identityHandler;
            _configuration = configuration;
            _cookieName = _configuration.GetSection("CookieNames");
        }

        [HttpPost("login")]
        public async Task<ActionResult<IdentityDTO>> Login([FromBody] IdentityDTO login)
        {
            User user = await _context.Users
                .Where(s => s.Email == login.Email).FirstOrDefaultAsync();

            string token = await _identityHandler.Login(login);
            if (token == null) return StatusCode(404);

            Console.WriteLine(token);
            Response.Cookies.Append(_cookieName.GetSection("ForumAPI").Value, token, new CookieOptions()
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true
            });
            return Ok(user);
        }

        [HttpPost("registeruser")]
        public async Task<ActionResult<IdentityDTO>> RegisterUser(IdentityDTO register)
        {
            User user = await _context.Users
                .Where(s => s.UserName == register.UserName).FirstOrDefaultAsync();
            //register.roles = new List<string> { };
            string token = await _identityHandler.Register(register);
            if (token == "bad" || token is null)
            {
                return StatusCode(406);
            }
            if (token == null) return StatusCode(404);
            user = await _context.Users
                .Where(s => s.UserName == register.UserName).FirstOrDefaultAsync();
            Console.WriteLine(token);
            Response.Cookies.Append(_cookieName.GetSection("ForumAPI").Value, token, new CookieOptions()
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true
            });
            return Ok(user);
        }

        [HttpPut("UpdatePassword")]
        public async Task<bool> UpdatePassword(UpdatePasswordDTO passwords)
        {
            return await _identityHandler.ChangePassword(this.User, passwords.OldPassword, passwords.NewPassword);
        }
    }
}
