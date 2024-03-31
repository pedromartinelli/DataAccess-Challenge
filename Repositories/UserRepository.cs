using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Blog_Challenge.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void InsertRoleIntoUser(int userId, int roleId)
        {
            if (userId == 0 || roleId == 0) return;

            const string sql = "INSERT INTO [UserRole] VALUES(@UserId, @RoleId)";

            _connection.Execute(sql, new
            {
                UserId = userId,
                RoleId = roleId
            });
        }
    }
}
