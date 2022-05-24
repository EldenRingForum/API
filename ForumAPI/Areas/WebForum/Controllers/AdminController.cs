﻿using ForumAPI.Areas.WebForum.Data.Context;
using ForumAPI.Areas.WebForum.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Areas.WebForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly WebForumContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(WebForumContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //Warn User
        //at the moment this does nothing because there isnt an email system yet, but its supposed to send email to the user and inform them
        [HttpGet("WarnUser")]
        public async Task<IActionResult> WarnUser()
        {

            return NoContent();
        }

        //Ban User
        //This just deletes the user but it should maybe just restric
        [HttpGet("BanUser/{id}")]
        public async Task<IActionResult> BanUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(s => s.Id == id);
            var userByEmail = await _userManager.FindByEmailAsync(user.Email);
            
            try
            {
                await _userManager.SetLockoutEnabledAsync(userByEmail, true);
                await _userManager.SetLockoutEndDateAsync(userByEmail, DateTime.Today.AddYears(100));

            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("You didnt ban the user");
                throw;
            }

            return NoContent();
        }

        #region Post Admin Tools
        //Delete Post
        [HttpPut("DeletePost")]
        public async Task<IActionResult> DeletePost(Post post)
        {
            post.Text = "Text has been deleted";
            post.Title = "Title text has been deleted";
            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(post.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
            // Skal erstatte tekst og til at den er (Thread Has been Deleted)
        }

        //Pin/Unpin Thread
        [HttpPut("PinUnpin")]
        public async Task<IActionResult> PinUnpinThread(Post post)
        {
            if (post.Stickied == false)
            {
                post.Stickied = true;
            }
            else if (post.Stickied == true)
            {
                post.Stickied = false;
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(post.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(post.Stickied);
        }

        private bool PostExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        #endregion

        #region Comment Admin Tools
        //Delete Comment
        [HttpPut("DeleteComment")]
        public async Task<IActionResult> DeleteComment(Comment comment)
        {
            // Skal lige testes færdig
            comment.Text = "Text has been deleted";
            _context.Entry(comment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(comment.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(comment);
            // Skal erstatte tekst og til at den er (Thread Has been Deleted)
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
        #endregion
    }
}