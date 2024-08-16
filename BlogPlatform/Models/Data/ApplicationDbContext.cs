using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Models.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<BlogPost> Blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Tag> tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BlogPost>()
                .HasMany(p => p.categories)
                .WithMany(c => c.blogPosts);
            modelBuilder.Entity<BlogPost>()
                .HasMany(p => p.tags)
                .WithMany(t => t.blogPosts);
        }
    }
}
