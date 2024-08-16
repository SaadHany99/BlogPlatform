using BlogPlatform.Models;
using BlogPlatform.Repositories;

namespace BlogPlatform.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository repository;

        public BlogPostService(IBlogPostRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddBlogPost(BlogPost blogPost)
        {
            await repository.AddBlogPost(blogPost);
        }

        public async Task DeleteBlogPost(int id)
        {
            await repository.DeleteBlogPost(id);
        }

        public async Task<List<BlogPost>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<BlogPost> GetBlogPostById(int id)
        {
            return await repository.GetBlogPostById(id);
        }

        public async Task UpdateBlogPost(BlogPost blogPost)
        {
            await repository.UpdateBlogPost(blogPost);
        }
    }
}
