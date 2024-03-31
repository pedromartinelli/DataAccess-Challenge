using Dapper.Contrib.Extensions;

namespace Blog_Challenge.Models
{
    [Table("[Role]")]
    public class Role : Base
    {
        public Role()
        {

        }

        public Role(string name, string slug) : base(name, slug)
        {
            Name = name;
            Slug = slug;
        }
    }
}
