using Blog_Challenge.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog_Challenge.Repositories
{
    public class Repository<TModel> where TModel : Base
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Create(TModel model)
        {
            model.Id = 0;
            _connection.Insert(model);
        }

        public IEnumerable<TModel> GetAll()
            => _connection.GetAll<TModel>();

        public TModel Get(int id)
            => _connection.Get<TModel>(id);

        public void Update(TModel model)
        {
            if (model.Id == 0) return;

            _connection.Update(model);
        }

        public void Delete(int id)
        {
            if (id == 0) return;

            var user = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(user);
        }

    }
}
