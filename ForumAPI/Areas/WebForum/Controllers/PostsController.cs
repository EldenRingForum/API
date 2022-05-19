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

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly WebForumContext _context;

        private int PostsToInclude = 10;

        public PostsController(WebForumContext context)
        {
            _context = context;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        [HttpGet("GetCategoryPosts/{id}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostsInCategory(int id)
        {
            var temp = await _context.Posts
                .Include(s => s.User)
                .Include(s => s.Comments)
                .Where(s => s.CategoryId == id)
                .ToListAsync();

            if (temp == null)
            {
                return NotFound();
            }

            return temp;
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var temp = await _context.Posts
                .Include(s => s.User)
                .Include(s => s.Comments)
                .ThenInclude(s => s.User)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (temp == null)
            {
                return NotFound();
            }

            return temp;
        }
        
        // GET: api/Posts/5
        [HttpGet("GetRecentPosts")]
        public async Task<ActionResult<IEnumerable<PostWithCategoryDTO>>> GetPost()
        {
            //Skal bruge en DTO hvis jeg skal vise både post og catogorien posten ligger i
            List<PostWithCategoryDTO> dtos = new List<PostWithCategoryDTO>();
            var temp = await _context.Posts
                .Include(s => s.Comments)
                .OrderBy(s => s.DateOfCreation)
                .ToListAsync();

            //Der må kun være 10, for at fjerne de resterende
            if (temp.Count > PostsToInclude)
            {
                temp.RemoveRange(PostsToInclude, temp.Count - PostsToInclude);
            }


            //for hver Post tilføjes en category til posten baseret på post.categoryid
            foreach (var post in temp)
            {
                PostWithCategoryDTO dto = new PostWithCategoryDTO();
                dto.CommentAmount = post.Comments.Count();
                dto.Post = post;
                dto.Category = await _context.Categories
                    .FirstOrDefaultAsync(s => s.Id == post.CategoryId);
                dtos.Add(dto);
            }
            

            if (temp == null)
            {
                return NotFound();
            }

            return dtos;
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, Post post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
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

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
