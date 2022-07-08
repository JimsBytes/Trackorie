namespace Trackorie.Model
{
    public class Ingredient
    {
        public Ingredient() : this("New Ingredient") { }

        public Ingredient(string name) : this(name, string.Empty) { }

        public Ingredient(string name, string description) : this(name, description, 0) { }

        public Ingredient(string name, int calories) : this(name, string.Empty, calories) { }

        public Ingredient(string name, string description, int calories)
        {
            Name = name;
            Description = description;
            Calories = calories;
        }

        public int IngredientId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public int Calories { get; set; }

        public ServingUnit CaloriesUnit { get; set; }

        public DateTime? Deleted { get; set; }

        public ICollection<FoodItemIngredient> FoodItemIngredients { get; set; } = null!;
    }
}
