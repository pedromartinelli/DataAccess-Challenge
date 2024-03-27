using Dapper.Contrib.Extensions;

namespace Blog_Challenge.Models
{
    [Table("[User]")]
    public class User : Base
    {

        public User()
        {

        }

        public User(string name, string email, string passwordHash, string bio, string image, string slug) : base(name, slug)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Bio = bio;
            Image = image;
            Slug = slug;
        }

        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string Image { get; set; } = null!;

        [Write(false)]
        public List<Role> Roles { get; set; } = new List<Role>();

        [Write(false)]
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
