namespace Trackorie.Model
{
    public class FoodItem
    {
        public FoodItem() : this("New Food Item") { }

        public FoodItem(string name)
        {
            Name = name;
        }

        public int FoodItemId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime? Deleted { get; set; }

        public ICollection<FoodItemIngredient> FoodItemIngredients { get; set; } = null!;

    }
}
