using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Challenge.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Menu de criação de usuário");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");

            Console.Write("Insira um nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira um email: ");
            var email = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira uma senha: ");
            var password = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira uma bio: ");
            var bio = Console.ReadLine();

            Console.WriteLine("");

            var user = new User(name!, email!, $"HS34{password}", bio!, "https:// ",$"{name}-{email!.Split('@').FirstOrDefault()}");
            
            Create(user);
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            UserMenu.Load();
        }

        private static void Create(User user)
        {
            var repository = new Repository<User>(Database.Connection);

            repository.Create(user);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Usuário cadastrado com sucesso!!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }
    }
}
