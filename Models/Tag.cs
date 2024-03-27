namespace Blog_Challenge.Models
{
    public class Tag : Base
    {
        public Tag(string name, string slug) : base(name, slug)
        {
            Name = name;
            Slug = slug;
        }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
