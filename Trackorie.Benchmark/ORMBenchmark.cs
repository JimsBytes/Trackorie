using BenchmarkDotNet.Attributes;
using Trackorie.DataInterface;
using Trackorie.Model;

namespace Trackorie.Benchmark
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ORMBenchmark
    {
        private IFoodItemRepository _ef = new ORM.EntityFrameworkDemo.Service.FoodItemRepository();
        private IFoodItemRepository _dapper = new ORM.DapperDemo.Service.FoodItemRepository();

        [Benchmark]
        public async Task<List<FoodItem>> GetEF()
        {
            return await _ef.List();
        }

        [Benchmark]
        public async Task<List<FoodItem>> GetDapper()
        {
            return await _dapper.List();
        }
    }
}
