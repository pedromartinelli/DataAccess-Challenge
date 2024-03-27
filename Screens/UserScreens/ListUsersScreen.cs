using Blog_Challenge.Models;
using Blog_Challenge.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog_Challenge.Screens.UserScreens
{
    public static class ListUsersScreen
    {

        public static void ListUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);

            var users = repository.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"\n{user.Name} - {user.Email}");
            }
        }
    }
}
