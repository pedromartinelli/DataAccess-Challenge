using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog;
using Console = System.Console;

namespace Blog_Challenge.Screens.UserScreens
{
    public static class UserMenu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Cadastrar usuário");
            Console.WriteLine("3 - Vincular um usuário a um perfil");
            Console.WriteLine("0 - Voltar para o menu principal");
            Console.WriteLine("");
            Console.Write("Selecione uma das opções acima: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    RoleToUserScreen.Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}

    
