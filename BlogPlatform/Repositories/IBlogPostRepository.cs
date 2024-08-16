using BlogPlatform.Models;

namespace BlogPlatform.Repositories
{
    public interface IBlogPostRepository
    {
        public Task<List<BlogPost>> GetAll();
        public Task<BlogPost> GetBlogPostById(int id);
        public Task AddBlogPost(BlogPost blogPost);
        public Task UpdateBlogPost(BlogPost blogPost);
        public Task DeleteBlogPost(int id);
    }
}
