using Blog_Challenge;
using Blog_Challenge.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Blog;

class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e!@#;TrustServerCertificate=true";

    static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(CONNECTION_STRING);
        Database.Connection.Open();

        Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

    private static void Load()
    {
        Console.WriteLine();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("--------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 --- Gerenciar usuários");
        Console.WriteLine("2 --- Voltar");
        Console.WriteLine("0 --- Sair da aplicação");
        Console.Write("Selecione uma das opções acima: ");
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListUsersScreen.ListUsers(Database.Connection);
                break;
            case 2:
                Load();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default: break;
        }

        Load();
    }
}