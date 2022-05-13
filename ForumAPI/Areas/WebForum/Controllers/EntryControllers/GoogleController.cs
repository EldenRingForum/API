using ForumAPI.Areas.Identity.Data;
using ForumAPI.Areas.Identity.Services;
using ForumAPI.Areas.WebForum.Data.Models.DTO;
using ForumAPI.Areas.WebForum.Data.Models;
using ForumAPI.Areas.WebForum.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ForumAPI.Areas.WebForum.Data.Context;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Areas.WebForum.Controllers.EntryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleController : ControllerBase
    {
        /*          GOOGLE LOGIN
        ***************************************
                    Opsummering

        ***************************************
        */

        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _cookieName;
        private readonly JWTHandler _jwtHandler;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WebForumContext _context;
        private readonly IdentityHandler _identityHandler;

        public GoogleController(
            IConfiguration configuration,
            JWTHandler JWTHandler,
            UserManager<IdentityUser> userManager,
            WebForumContext context,
            IdentityHandler identityHandler
            )
        {
            _configuration = configuration;
            _jwtHandler = JWTHandler;
            _userManager = userManager;
            _context = context;
            _identityHandler = identityHandler;
            _cookieName = _configuration.GetSection("CookieNames");
        }

        //TODO: skal lige laves sådan at usernames kommer med ind over
        //this function logs the user in on our server end with google login and returns a cookie in httponly format for CRSF security
        #region Google login
        [HttpPost("login")]
        public async Task<IActionResult> GoogleLogin([FromBody] ExternalAuthDTO externalAuthDTO)
        {
            var payload = await _jwtHandler.VerifyGoogleToken(externalAuthDTO);
            if (payload == null)
                return BadRequest("invalid External Auth");

            var info = new UserLoginInfo(externalAuthDTO.Provider, payload.Subject, externalAuthDTO.Provider);

            //logs the user to the identity
            var identityUser = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
            if (identityUser == null)
            {

                identityUser = await _userManager.FindByEmailAsync(payload.Email);
                if (identityUser == null)
                {

                    User profile = new User { UserName = externalAuthDTO.UserName, Email = payload.Email };
                    Roles roles = new Roles();

                   
                    _context.Users.Add(profile);
                    _context.SaveChanges();

                    identityUser = new IdentityUser { Email = payload.Email, UserName = externalAuthDTO.UserName, EmailConfirmed = true };

                    await _userManager.CreateAsync(identityUser);
                    await _identityHandler.AddRoleToUser(payload.Email, roles.roles[0]);

                    await _userManager.AddLoginAsync(identityUser, info);

                }
                else
                {
                    await _userManager.AddLoginAsync(identityUser, info);
                }
            }

            if (identityUser == null)
                return BadRequest("Invalid External Authentication.");


            User user = await _context.Users
            .Where(s => s.Email == identityUser.Email).FirstOrDefaultAsync();

            if (user == null)
            {
                Console.WriteLine("something bad happpened");
            }

            var token = await _jwtHandler.GenerateToken(identityUser);
            Response.Cookies.Append(_cookieName.GetSection("ForumAPI").Value, token, new CookieOptions()
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true
            });
            return Ok(new AuthResponseDTO { Token = token, IsAuthSuccessful = true, Message = user.UserName });
        }
        #endregion
    }
}
