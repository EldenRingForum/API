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

        /// <summary>
        /// Registrer og logger brugeren ind med googles SSO,
        /// </summary>
        /// <param name="externalAuthDTO"></param>
        /// <returns>
        /// samt om den funktionen fuldførte sit job med IsAuthSuccesful = true
        /// Den returnere en token som HttpOnly, secure og samesite.none
        /// </returns>
        //this function logs the user in on our server with a google account and returns a cookie in httponly format for CRSF security
        #region Google login
        [HttpPost("login")]
        public async Task<IActionResult> GoogleLogin([FromBody] ExternalAuthDTO externalAuthDTO)
        {
            //checker om det er den korrekte information vi har fået fra brugeren.
            var payload = await _jwtHandler.VerifyGoogleToken(externalAuthDTO);
            if (payload == null)
                return BadRequest("invalid External Auth");

            //sætter variabler vi kan bruge det som et objekt
            var info = new UserLoginInfo(externalAuthDTO.Provider, payload.Subject, externalAuthDTO.Provider);

            //Checker har oprettet sig selv via google login
            var identityUser = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
            if (identityUser == null)
            {
                // checker om kontoen allerede findes i databasen
                identityUser = await _userManager.FindByEmailAsync(payload.Email);
                if (identityUser == null)
                {
                    // Frontend burde tage sig af det her check men er her for en sikkerheds skyld
                    if (externalAuthDTO.UserName is null)
                    {
                        return BadRequest("Your username is null");
                    }
                    // laver ny bruger
                    User profile = new User { UserName = externalAuthDTO.UserName, Email = payload.Email };
                    Roles roles = new Roles();

                    //gemmer information i databasen
                    _context.Users.Add(profile);
                    _context.SaveChanges();

                    //ny identity bruger
                    identityUser = new IdentityUser { Email = payload.Email, UserName = externalAuthDTO.UserName, EmailConfirmed = true };

                    await _userManager.CreateAsync(identityUser);
                    await _identityHandler.AddRoleToUser(payload.Email, roles.roles[0]);
                    //tilføjer rolle til bruger
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

            //Burde ikke kunne logge ind hvis den ikke kan finde i databasen, så er der gået noget galt.
            if (user == null)
            {
                Console.WriteLine("something bad happpened");
            }

            // generere en token til systemet.
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
