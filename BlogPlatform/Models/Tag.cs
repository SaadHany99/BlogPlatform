namespace BlogPlatform.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BlogPost> blogPosts { get; set; }
    }
}
