using Microsoft.EntityFrameworkCore;
using Trackorie.Model;

namespace Trackorie.ORM.EntityFrameworkDemo.Data
{
    public class TrackorieDbContext : DbContext
    {
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();
        public DbSet<Ingredient> Ingredients => Set<Ingredient>();

        public TrackorieDbContext() : base() { }

        public TrackorieDbContext(DbContextOptions<TrackorieDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Trackorie;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .Property(f => f.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<FoodItemIngredient>()
                .HasKey(t => new { t.FoodItemId, t.IngredientId });

            modelBuilder.Entity<FoodItemIngredient>()
                .HasOne(fi => fi.FoodItem)
                .WithMany(p => p.FoodItemIngredients)
                .HasForeignKey(fi => fi.FoodItemId);

            modelBuilder.Entity<FoodItemIngredient>()
                .HasOne(fi => fi.Ingredient)
                .WithMany(f => f.FoodItemIngredients)
                .HasForeignKey(fi => fi.IngredientId);

            // Seed data
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient() { IngredientId = 1, Name = "Butter", Description = "Butter is a dairy product made from the fat and protein components of churned cream. It is a semi-solid emulsion at room temperature, consisting of approximately 80% butterfat.", Calories = 717, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 2, Name = "Golden Caster Sugar", Description = "Golden caster sugar is a fine granulated sugar that is made from unrefined sugar cane or beets. It is popular in the UK for its colour, which is a pale golden brown, and it has a slightly buttery flavour. It is unfortunately fairly unique to the UK. The important point to make is that it is a dry, free-flowing sugar.", Calories = 399, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 3, Name = "Egg", Description = "Eggs are a natural source of many nutrients including high quality protein, vitamins and minerals.", Calories = 131, CaloriesUnit = ServingUnit.WHOLE },
                new Ingredient() { IngredientId = 4, Name = "Vanilla Extract", Description = "Vanilla extract is a solution made by macerating and percolating vanilla pods in a solution of ethanol and water. It is considered an essential ingredient in many Western desserts, especially baked goods like cakes, cookies, brownies, and cupcakes, as well as custards, ice creams, and puddings. ", Calories = 288, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 5, Name = "Self-Raising Flour", Description = "Self-rising flour is flour with the baking powder and a bit of salt already added. ", Calories = 336, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 6, Name = "Whole Milk", Description = "Whole milk is sometimes referred to as “regular milk” because the amount of fat in it has not been altered.", Calories = 62, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 7, Name = "Sunflower Oil", Description = "Sunflower oil is the non-volatile oil pressed from the seeds of the sunflower. Sunflower oil is commonly used in food as a frying oil, and in cosmetic formulations as an emollient. Sunflower oil is primarily composed of linoleic acid, a polyunsaturated fat, and oleic acid, a monounsaturated fat.", Calories = 884, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 8, Name = "Plain FLour", Description = "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. \"Plain\" refers not only to middling gluten content but also to its lack of any added leavening agent (as in self-rising flour).", Calories = 364, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 9, Name = "Maris Piper Potato", Description = "Maris Pipers are readily available in supermarkets and greengrocers. The Maris Piper has a golden skin and creamy white flesh with a fluffy texture. This makes it a versatile all rounder, great for chips and roast potatoes, but also good for mash and wedges.", Calories = 81, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 10, Name = "Olive Oil", Description = "Olive oil is a liquid fat obtained from olives a traditional tree crop of the Mediterranean Basin, produced by pressing whole olives and extracting the oil.", Calories = 884, CaloriesUnit = ServingUnit.PER_100G },
                new Ingredient() { IngredientId = 11, Name = "Sea Salt", Description = "Sea salt is salt that is produced by the evaporation of seawater. It is used as a seasoning in foods, cooking, cosmetics and for preserving food. It is also called bay salt, solar salt, or simply salt", Calories = 0, CaloriesUnit = ServingUnit.PER_100G }
            );

            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem() { FoodItemId = 1, Name = "Sponge Cake", Description = "Choose your favourite filling for this easy, perfectly fluffy sponge cake." },
                new FoodItem() { FoodItemId = 2, Name = "Pancakes", Description = "Foolproof easy crêpe recipe that ensures perfect pancakes every time – elaborate flip optional." },
                new FoodItem() { FoodItemId = 3, Name = "Homemade Oven Chips", Description = "Achieve the perfect oven-roasted chips at home with a fluffy interior and crispy skin. These are much easier to cook and lower in fat than fried." }
            );

            modelBuilder.Entity<FoodItemIngredient>().HasData(
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 1, Amount = 225, Unit = ServingUnit.PER_1G },
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 2, Amount = 225, Unit = ServingUnit.PER_1G },
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 3, Amount = 4, Unit = ServingUnit.WHOLE },
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 4, Amount = 1, Unit = ServingUnit.TSP },
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 5, Amount = 225, Unit = ServingUnit.PER_1G },
                new FoodItemIngredient() { FoodItemId = 1, IngredientId = 6, Amount = 20, Unit = ServingUnit.PER_1ML },
                new FoodItemIngredient() { FoodItemId = 2, IngredientId = 8, Amount = 100, Unit = ServingUnit.PER_1G },
                new FoodItemIngredient() { FoodItemId = 2, IngredientId = 3, Amount = 2, Unit = ServingUnit.WHOLE },
                new FoodItemIngredient() { FoodItemId = 2, IngredientId = 6, Amount = 300, Unit = ServingUnit.PER_1ML },
                new FoodItemIngredient() { FoodItemId = 3, IngredientId = 9, Amount = 1.6, Unit = ServingUnit.PER_KG },
                new FoodItemIngredient() { FoodItemId = 3, IngredientId = 10, Amount = 2, Unit = ServingUnit.TBSP },
                new FoodItemIngredient() { FoodItemId = 3, IngredientId = 11, Amount = 1, Unit = ServingUnit.TSP }
            );
        }
    }
}
