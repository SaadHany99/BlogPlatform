namespace BlogPlatform.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BlogPost> blogPosts { get; set; }
    }
}
