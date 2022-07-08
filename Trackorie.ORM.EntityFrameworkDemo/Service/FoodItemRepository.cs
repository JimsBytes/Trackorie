using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Trackorie.DataInterface;
using Trackorie.ORM.EntityFrameworkDemo.Data;
using Trackorie.Model;

namespace Trackorie.ORM.EntityFrameworkDemo.Service
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private TrackorieDbContext _trackorieDbContext = new();

        public async Task<FoodItem?> GetById(int id)
        {
            return await _trackorieDbContext
                .FoodItems
                .FindAsync(id);
        }

        public async Task<List<FoodItem>> List()
        {
            return await _trackorieDbContext
                .FoodItems
                .ToListAsync();
        }

        public async Task<IEnumerable<FoodItem>> List(Expression<Func<FoodItem, bool>> predicate)
        {
            return await _trackorieDbContext
                .FoodItems
                .Where(predicate)
                .ToListAsync();
        }

        public async Task<FoodItem> Add(FoodItem entity)
        {
            _trackorieDbContext.FoodItems.Add(entity);
            await _trackorieDbContext.SaveChangesAsync();

            return entity;
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
