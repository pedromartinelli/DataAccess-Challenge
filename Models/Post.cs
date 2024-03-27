using Dapper.Contrib.Extensions;

namespace Blog_Challenge.Models
{
    [Table("[Post]")]
    public class Post : Base
    {
        public Post(int categoryId, int authorId, string title, string summary, string body, string slug) : base(slug)
        {
            CategoryId = categoryId;
            AuthorId = authorId;
            Title = title;
            Summary = summary;
            Body = body;
            Slug = slug;
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int AuthorId { get; set; }
        public User Author { get; set; } = null!;

        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [Write(false)]
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
