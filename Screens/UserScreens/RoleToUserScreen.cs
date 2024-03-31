using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Challenge.Screens.UserScreens
{
    public class RoleToUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincule um perfil a um usuário");
            Console.WriteLine("-----------------");

            Console.WriteLine("Perfis");
            ListRoles();
            Console.WriteLine("");

            Console.WriteLine("Usuários");
            ListUsers();
            Console.WriteLine("");

            Console.Write("Insira um id de usuário: ");
            var userId = short.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            Console.Write("Insira um id de perfil: ");
            var roleId = short.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            AddRole(userId, roleId);

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
            UserMenu.Load();
        }

        private static void AddRole(int userId, int roleId)
        {
            var repository = new UserRepository(Database.Connection);

            repository.InsertRoleIntoUser(userId, roleId);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Perfil de id {roleId} adicionado ao usuário de id {userId} com sucesso!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }

        private static void ListUsers()
        {
            var repository = new Repository<User>(Database.Connection);

            var users = repository.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"\n{user.Id} - {user.Name} - {user.Email}");
            }
        }

        private static void ListRoles()
        {
            var repository = new Repository<Role>(Database.Connection);

            var roles = repository.GetAll();

            foreach (var role in roles)
            {
                Console.WriteLine($"\n{role.Id} - {role.Name}");
            }
        }
    }
}
