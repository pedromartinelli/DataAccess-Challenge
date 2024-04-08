using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Challenge.Screens.CategoryScreens
{
    public class ListCategoriesWithPostsQuantityScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias com quantidade de posts");
            Console.WriteLine("-----------------");
            List();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            CategoryMenu.Load();
        }

        private static void List()
        {
            var repository = new CategoryRepository(Database.Connection);

            var categories = repository.ListWithPostsQuantity();

            foreach (var category in categories)
            {
                Console.WriteLine($"\n{category.Name} - {category.Posts.Count}");
            }
        }
    }
}
