namespace Trackorie.Model
{
    public class FoodItemIngredient
    {
        public int FoodItemId { get; set; }
        public FoodItem FoodItem { get; set; } = null!;


        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;

        public double Amount { get; set; }

        public ServingUnit Unit { get; set; }
    }
}
