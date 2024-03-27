using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog;

class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e!@#;TrustServerCertificate=true";
    static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();
        ReadUser(connection, 2);
        connection.Close();
    }

    public static void ReadUser(SqlConnection connection, int id)
    {
        var repository = new Repository<User>(connection);

        var user = repository.Get(id);

        Console.WriteLine($"\n{user.Name} - {user.Email}");
    }
}