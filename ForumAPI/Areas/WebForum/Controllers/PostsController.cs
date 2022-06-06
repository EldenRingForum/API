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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly WebForumContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        private int PostsToInclude = 10;

        public PostsController(WebForumContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        [HttpGet("GetCategoryPosts/{id}")]
        public async Task<ActionResult<UnpinnedAndPinnedPostsDTO>> GetPostsInCategory(int id)
        {
            UnpinnedAndPinnedPostsDTO dto = new UnpinnedAndPinnedPostsDTO()
            {
                UnpinnedPosts = await _context.Posts
                .Include(s => s.User)
                .Include(s => s.Comments)
                .Where(s => s.CategoryId == id && s.Stickied == false)
                .ToListAsync(),

                PinnedPosts = await _context.Posts
                .Include(s => s.User)
                .Include(s => s.Comments)
                .Where(s => s.CategoryId == id && s.Stickied == true)
                .ToListAsync(),

            };

            foreach (var post in dto.UnpinnedPosts)
            {
                post.CommentAmount = post.Comments.Count;
                post.Comments = null;

            }
            foreach (var post in dto.PinnedPosts)
            {
                post.CommentAmount = post.Comments.Count;
                post.Comments = null;
            }


            if (dto == null)
            {
                return NotFound();
            }

            return dto;
        }



        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPostFromCat(int id)
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
                dto.TimeOfCreation = dto.Post.DateOfCreation.ToString("g");                
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

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Policy = "USER")]
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            var temp = _userManager.GetUserName(this.User);
            var user = await _userManager.FindByEmailAsync(temp);
            var _User = await _context.Users.FirstOrDefaultAsync(s => s.Email == user.Email);
            post.UserId = _User.Id;
            post.DateOfCreation = DateTime.Now;
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            post.User = _User;
            return Ok(post);
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
