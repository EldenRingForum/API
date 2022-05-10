using ForumAPI.Areas.WebForum.Data.Models.DTO;
using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.AspNetCore.Identity;
using ForumAPI.Areas.WebForum.Data.Context;
using ForumAPI.Areas.WebForum.Services;

namespace ForumAPI.Areas.Identity.Services
{
    public class IdentityHandler
    {
        // Skal renames til noget specifikt eller muligvis laves helt om sådan at koden lægger i controllers

        private readonly WebForumContext _context;
        private readonly JWTHandler _JWTHandler;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IdentityHandler(
            WebForumContext context,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            JWTHandler JWTHandler
            )
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _JWTHandler = JWTHandler;
        }

        #region RoleHandling
        // SKAL/KAN MÅSKE FLYTTES IND I REGISTER FUNKTIONEN
        #region Adding roles
        public async Task<bool> AddMultipleRolesToUser(string user, List<string> roles)
        {
            foreach (var role in roles)
            {
                var userRoleCheck = await _roleManager.RoleExistsAsync(role);

                if (!userRoleCheck)
                {
                    Console.WriteLine("ROLES NOT WITHING SPECIFIED PARAMETERS");
                    return false;
                }

                IdentityUser identityUser = await _userManager.FindByEmailAsync(user);
                await _userManager.AddToRoleAsync(identityUser, role);
            }
            return true;
        }

        public async Task<bool> AddRoleToUser(string user, string role)
        {
            var userRoleCheck = await _roleManager.RoleExistsAsync(role);

            if (!userRoleCheck)
            {
                Console.WriteLine("ROLES NOT WITHING SPECIFIED PARAMETERS");
                return false;
            }

            IdentityUser identityUser = await _userManager.FindByEmailAsync(user);
            await _userManager.AddToRoleAsync(identityUser, role);
            return true;
        }
        #endregion

        public async Task RemoveRoleFromUser(string user, string role)
        {
            var userRoleCheck = await _roleManager.RoleExistsAsync(role);
            var userCheck = await _userManager.FindByEmailAsync(user);

            if (userCheck is null)
            {
                Console.WriteLine("USER DOESNT EXIST");
                return;
            }
            if (!userRoleCheck)
            {
                Console.WriteLine("ROLES NOT WITHING SPECIFIED PARAMETERS");
                return;
            }

            await _userManager.RemoveFromRoleAsync(userCheck, role);
        }
        #endregion


        #region Entry
        public async Task<string> Login(IdentityDTO login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.email, login.password, login.rememberMe, lockoutOnFailure: false);
            var user = await _userManager.FindByEmailAsync(login.email);

            if (result.Succeeded)
            {
                login.password = "";
                login.email = "";

                Console.WriteLine("User logged in with email: ", login.email);

                var token = await _JWTHandler.GenerateToken(user);
                //Create token with JWT HANDLER

                return token;
            }

            return null;
        }

        public async Task<string> Register(IdentityDTO login)
        {
            if (await _userManager.FindByEmailAsync(login.email) is not null) return "bad";
            if (login.password != login.confirmPassword) return "bad";

            var user = new IdentityUser { UserName = login.email, Email = login.email, EmailConfirmed = true };
            var result = await _userManager.CreateAsync(user, login.password);

            if (result.Succeeded)
            {
                User profile = new User { UserName = login.email };

                await AddMultipleRolesToUser(profile.UserName, login.roles);
                _context.Users.Add(profile);
                _context.SaveChanges();
                login.password = "";
                login.email = "";

                Console.WriteLine("User created with email: ", login.email);

                var token = await _JWTHandler.GenerateToken(user);

                return token;
            }
            else
            {
                await _userManager.DeleteAsync(user);
            }
            return null;
        }
        #endregion
    }
}
