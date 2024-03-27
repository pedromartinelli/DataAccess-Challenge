using Dapper.Contrib.Extensions;

namespace Blog_Challenge.Models
{
    [Table("[Tag]")]
    public class Tag : Base
    {
        public Tag(string name, string slug) : base(name, slug)
        {
            Name = name;
            Slug = slug;
        }

        [Write(false)]
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
