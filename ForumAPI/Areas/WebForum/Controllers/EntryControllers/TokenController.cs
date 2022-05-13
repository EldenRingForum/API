using ForumAPI.Areas.WebForum.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Areas.WebForum.Controllers.EntryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly JWTHandler _jwtHandler;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _cookieName;
        private readonly IConfigurationSection _jwtSettings;

        public TokenController(
            IConfiguration configuration,
            JWTHandler JWTHandler
            )
        {

            _jwtHandler = JWTHandler;
            _configuration = configuration;
            _cookieName = _configuration.GetSection("CookieNames");
            _jwtSettings = _configuration.GetSection("JWTSettings");
        }

        [HttpGet("removetoken")]
        public bool RemoveToken()
        {
            var token = Request.Cookies[_cookieName.GetSection("WebForumAPI").Value];
            if (token == null) return false;

            token = "";
            Response.Cookies.Append(_cookieName.GetSection("WebForumAPI").Value, token, new CookieOptions()
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true
            });
            return false;
        }

        // POST api/<GenericActionsController>
        [HttpGet("checktoken")]
        public bool CheckToken()
        {
            var token = Request.Cookies[_cookieName.GetSection("WebForumAPI").Value];
            if (token == null) return false;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.GetSection("securityKey").Value);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }
    }
}
