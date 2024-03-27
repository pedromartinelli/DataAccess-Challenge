namespace Blog_Challenge.Models
{
    public class Category : Base
    {
        public Category(string name, string slug) : base(name, slug)
        {
            Name = name;
            Slug = slug;
        }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
