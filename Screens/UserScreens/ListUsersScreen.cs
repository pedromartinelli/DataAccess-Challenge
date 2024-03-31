using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog_Challenge.Screens.UserScreens
{
    public static class ListUsersScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-----------------");
            List();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            UserMenu.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);

            var users = repository.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"\n{user.Name} - {user.Email}");
            }
        }
    }
}
