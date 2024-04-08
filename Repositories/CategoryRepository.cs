using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Challenge.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Blog_Challenge.Repositories
{
    public class CategoryRepository
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Category> ListWithPostsQuantity()
        {
            var categories = _connection.GetAll<Category>().ToList();

            var sql = "SELECT * FROM [Post] WHERE [CategoryId] = @CategoryId";

            foreach (var category in categories)
            {
                category.Posts = _connection.Query<Post>(sql, new { CategoryId = category.Id }).ToList();
            }

            return categories;
        }
    }
}
