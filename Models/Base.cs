namespace Blog_Challenge.Models
{
    public class Base
    {

        public Base()
        {

        }

        public Base(string slug)
        {
            Slug = slug;
        }

        public Base(string name, string slug)
        {
            Name = name;
            Slug = slug;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
    }
}
