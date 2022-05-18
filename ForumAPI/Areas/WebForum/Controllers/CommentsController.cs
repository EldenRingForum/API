using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ForumAPI.Areas.WebForum.Data.Context;
using ForumAPI.Areas.WebForum.Data.Models;
using ForumAPI.Areas.WebForum.Data.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly WebForumContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CommentsController(WebForumContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: api/Comments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
        {
            return await _context.Comments.ToListAsync();
        }

        /*
        // GET: api/Comments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentsWithUserDTO>> GetComment(int id)
        {
            var dto = new CommentsWithUserDTO
            {
                
            };


            if (dto == null)
            {
                return NotFound();
            }

            return dto;
        }
        */

        // PUT: api/Comments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, Comment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest();
            }

            _context.Entry(comment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Comments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Policy = "USER")]
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
{
            var temp = _userManager.GetUserName(this.User);
            var user = await _userManager.FindByEmailAsync(temp);
            var _User = await _context.Users.FirstOrDefaultAsync(s => s.Email == user.Email);
            comment.UserId = _User.Id;
            comment.TimeOfCreation = DateTime.Now;
            if (comment.Text == null || comment.Text == "")
            {
                return BadRequest("You arent logged in ");
            }
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Comments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
