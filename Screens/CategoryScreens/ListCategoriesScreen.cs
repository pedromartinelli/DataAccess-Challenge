using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using Blog_Challenge.Screens.UserScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Challenge.Screens.CategoryScreens
{
    public static class ListCategoriesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-----------------");
            List();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            CategoryMenu.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);

            var categories = repository.GetAll();

            foreach (var category in categories)
            {
                Console.WriteLine($"\n{category.Id} - {category.Name} - {category.Slug}");
            }
        }
    }
}
