using Blog;
using Blog_Challenge.Screens.UserScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Challenge.Screens.CategoryScreens
{
    public static class CategoryMenu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Listar categorias com quantidade de posts");
            Console.WriteLine("3 - Cadastrar categoria");
            Console.WriteLine("0 - Voltar para o menu principal");
            Console.WriteLine("");
            Console.Write("Selecione uma das opções acima: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListCategoriesScreen.Load();
                    break;
                case 2:
                    ListCategoriesWithPostsQuantityScreen.Load();
                    break;
                case 3:
                    Console.WriteLine("Cadastrar categoria");
                    break;
                case 0:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
