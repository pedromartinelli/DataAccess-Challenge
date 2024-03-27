namespace Blog_Challenge.Models
{
    public class User : Base
    {
        public User(string name, string email, string passwordHash, string bio, string image, string slug) : base(name, slug)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Bio = bio;
            Image = image;
            Slug = slug;
        }

        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }

        public List<Role> Roles { get; set; } = new List<Role>();
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
