namespace BloggerPlus.API.Model.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlHandle { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
