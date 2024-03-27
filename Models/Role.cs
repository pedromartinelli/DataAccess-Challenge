namespace Blog_Challenge.Models
{
    public class Role : Base
    {
        public Role(string name, string slug) : base(name, slug)
        {
            Name = name;
            Slug = slug;
        }
    }
}
