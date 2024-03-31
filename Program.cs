using Blog_Challenge;
using Blog_Challenge.Screens.UserScreens;
using Microsoft.Data.SqlClient;
using InvalidOperationException = System.InvalidOperationException;

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

    public static void Load()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Meu Blog");
        Console.WriteLine("--------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("");
        Console.WriteLine("1 --- Gestão de usuário");
        Console.WriteLine("0 --- Sair da aplicação");
        Console.WriteLine("");
        Console.Write("Selecione uma das opções acima: ");
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                UserMenu.Load();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default: Load(); break;
        }
    }
}