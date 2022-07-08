namespace Trackorie.Model
{
    public class FoodItemIngredient
    {
        public int FoodItemId { get; set; }

        public int IngredientId { get; set; }

        public FoodItem FoodItem { get; set; } = null!;

        public Ingredient Ingredient { get; set; } = null!;
    }
}
