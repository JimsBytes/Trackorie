using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using Trackorie.DataInterface;
using Trackorie.Model;

namespace Trackorie.ORM.DapperDemo.Service
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly IDbConnection _dbConnetion;

        public FoodItemRepository()
        {
            _dbConnetion = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=Trackorie;Trusted_Connection=True;");
        }

        public Task<FoodItem?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FoodItem>> List()
        {
            return (await _dbConnetion.QueryAsync<FoodItem>("SELECT * FROM FoodItems")).ToList();
        }

        public Task<IEnumerable<FoodItem>> List(Expression<Func<FoodItem, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<FoodItem> Add(FoodItem entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(FoodItem entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(FoodItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
