using BlogPlatform.Models;

namespace BlogPlatform.Services
{
    public interface IBlogPostService
    {
        public Task<List<BlogPost>> GetAll();
        public Task<BlogPost> GetBlogPostById(int id);
        public Task AddBlogPost(BlogPost blogPost);
        public Task UpdateBlogPost(BlogPost blogPost);
        public Task DeleteBlogPost(int id);
    }
}
