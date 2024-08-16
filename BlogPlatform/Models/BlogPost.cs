namespace BlogPlatform.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Category>? categories { get; set; }
        public List<Tag>? tags { get; set; }

    }
}
