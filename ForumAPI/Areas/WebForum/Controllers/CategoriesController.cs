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

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly WebForumContext _context;

        public CategoriesController(WebForumContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("GetCategoryWithPost/{id}")]
        public async Task<ActionResult<Category>> GetCatWithPost(int id)
        {
            var temp = await _context.Categories
                .Include(s => s.Post)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (temp == null)
            {
                return NotFound();
            }
            return temp;
        }

        // GET: api/Categories/5
        [HttpGet("GetCatWithMod/{id}")]
        public async Task<ActionResult<CategoriesWithModeratorsDTO>> GetCatWithMod(int id)
        {
            var temp = new CategoriesWithModeratorsDTO();
            
            var moderator = await _context.Moderators
                    .Where(s => s.CategoryId == id)
                    .ToListAsync();
            foreach (var User in moderator)
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Id == User.Id);
                temp.Users.Add(user);
            }
            temp.Category = _context.Categories
                .FirstOrDefault(u => u.Id == id);

            if (temp == null)
            {
                return NotFound();
            }

            return temp;
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Policy = "MODERATOR")]
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [Authorize(Policy = "MODERATOR")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
