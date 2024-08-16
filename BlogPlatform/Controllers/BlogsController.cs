using BlogPlatform.Models;
using BlogPlatform.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogPostService service;

        public BlogsController(IBlogPostService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<ActionResult> AllBlogPosts()
        {
            var posts = await service.GetAll();
            return Ok(posts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> BlogPost(int id)
        {
            var post = await service.GetBlogPostById(id);
            if (post == null)
                return NotFound();
            return Ok(post);
        }
        [HttpPost]
        public async Task<ActionResult> CreatePost(BlogPost blog)
        {
            await service.AddBlogPost(blog);
            //nameof(GetBlogPost), new { id = blogPost.Id }, blogPost
            return CreatedAtAction(nameof(BlogPost), new { id = blog.Id }, blog);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePost(int id, BlogPost blogPost)
        {
            if (id != blogPost.Id)
            {
                return BadRequest();
            }

            await service.UpdateBlogPost(blogPost);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBlogPost(int id)
        {
            await service.DeleteBlogPost(id);
            return NoContent();
        }
    }
}
