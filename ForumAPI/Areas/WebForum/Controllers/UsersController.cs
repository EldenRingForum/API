using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ForumAPI.Areas.WebForum.Data.Context;
using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ForumAPI.Areas.WebForum.Data.Models.DTO;

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly WebForumContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(WebForumContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        //for testing purposes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var email = _userManager.GetUserName(this.User);
            var user = await _userManager.FindByEmailAsync(email);
            return await _context.Users.ToListAsync();
        }

        [HttpGet("GetUser")]
        public async Task<ActionResult<User>> GetUser()
        {
            if (this.User.Identity.Name is null)
            {
                return NoContent();
            }
            var email = _userManager.GetUserName(this.User);
            var user = await _userManager.FindByEmailAsync(email);
            return await _context.Users.FirstOrDefaultAsync(s => s.Email == user.Email);
        }

        [HttpGet("GetPostWithComments")]
        public async Task<ActionResult<UserWithPostsAndCommentsDTO>> GetUserHistory()
        {
            var temp = _userManager.GetUserName(this.User);
            var user = await _userManager.FindByEmailAsync(temp);
            UserWithPostsAndCommentsDTO dto = new UserWithPostsAndCommentsDTO();

            var _User = await _context.Users.FirstOrDefaultAsync(s => s.Email == user.Email);
            dto._Post = await _context.Posts
                .Where(s => s.UserId == _User.Id)
                .ToListAsync();
            dto._Comments = await _context.Comments
                .Where(s => s.UserId == _User.Id)
                .ToListAsync();

            if (dto == null)
            {
                return NotFound();
            }

            return dto;
        }

        [HttpGet("GetComments/{id}")]
        public async Task<ActionResult<List<Comment>>> GetMyComments(int id)
        {
            var user = await _context.Comments
                .Where(s => s.UserId == id)
                //.Include(s => s.Comments)
                .ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPut("UpdateImage")]
        public async Task<ActionResult<User>> UpdateImage(User userPfp)
        {
            if (this.User.Identity.Name is null)
            {
                return NoContent();
            }
            var temp = _userManager.GetUserName(this.User);
            var identityuser = await _userManager.FindByEmailAsync(temp);
            var user = await _context.Users.FirstOrDefaultAsync(s => s.Email == identityuser.Email);
            user.ProfilePicture = userPfp.ProfilePicture;

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
