using BlogPlatform.Models;
using BlogPlatform.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext context;

        public BlogPostRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddBlogPost(BlogPost blogPost)
        {
            await context.Blogs.AddAsync(blogPost);
            await context.SaveChangesAsync();
        }

        public async Task DeleteBlogPost(int id)
        {
            var selectedPost = await context.Blogs.FindAsync(id);
            if (selectedPost != null)
            {
                context.Blogs.Remove(selectedPost);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<BlogPost>> GetAll()
        {
            return await context.Blogs.Include(c => c.categories).Include(t => t.tags).ToListAsync();
        }

        public async Task<BlogPost> GetBlogPostById(int id)
        {
            return await context.Blogs.Include(c => c.categories).Include(t => t.tags)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateBlogPost(BlogPost blogPost)
        {
            context.Blogs.Update(blogPost);
            await context.SaveChangesAsync();
        }
    }
}
