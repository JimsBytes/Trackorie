using Microsoft.AspNetCore.Mvc;
using Trackorie.DataInterface;
using Trackorie.Model;

namespace Trackorie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemsController : ControllerBase
    {
        private IFoodItemRepository _foodItemRepository;

        public FoodItemsController(IFoodItemRepository foodItemRepository)
        {
            _foodItemRepository = foodItemRepository;
        }

        // GET: api/<FoodItemsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodItem>>> Get()
        {
            return await _foodItemRepository.List();
        }

        // GET api/<FoodItemsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodItem>> Get(int id)
        {
            var foodItem = await _foodItemRepository.GetById(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            return foodItem;
        }

        // POST api/<FoodItemsController>
        [HttpPost]
        public async Task<ActionResult<FoodItem>> Post(FoodItem foodItem)
        {
            var savedItem = await _foodItemRepository.Add(foodItem);

            return CreatedAtAction(nameof(Get), new { id = savedItem.FoodItemId }, foodItem);
        }

        // PUT api/<FoodItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FoodItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
