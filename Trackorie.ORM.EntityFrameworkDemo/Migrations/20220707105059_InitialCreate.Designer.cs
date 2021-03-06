// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trackorie.ORM.EntityFrameworkDemo.Data;

#nullable disable

namespace Trackorie.ORM.EntityFrameworkDemo.Migrations
{
    [DbContext(typeof(TrackorieDbContext))]
    [Migration("20220707105059_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Trackorie.Model.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemId"), 1L, 1);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("FoodItemId");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            FoodItemId = 1,
                            Description = "Choose your favourite filling for this easy, perfectly fluffy sponge cake.",
                            Name = "Sponge Cake"
                        },
                        new
                        {
                            FoodItemId = 2,
                            Description = "Foolproof easy crêpe recipe that ensures perfect pancakes every time – elaborate flip optional.",
                            Name = "Pancakes"
                        },
                        new
                        {
                            FoodItemId = 3,
                            Description = "Achieve the perfect oven-roasted chips at home with a fluffy interior and crispy skin. These are much easier to cook and lower in fat than fried.",
                            Name = "Homemade Oven Chips"
                        });
                });

            modelBuilder.Entity("Trackorie.Model.FoodItemIngredient", b =>
                {
                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("FoodItemId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("FoodItemIngredient");

                    b.HasData(
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 2
                        },
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 3
                        },
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 4
                        },
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 5
                        },
                        new
                        {
                            FoodItemId = 1,
                            IngredientId = 6
                        },
                        new
                        {
                            FoodItemId = 2,
                            IngredientId = 8
                        },
                        new
                        {
                            FoodItemId = 2,
                            IngredientId = 3
                        },
                        new
                        {
                            FoodItemId = 2,
                            IngredientId = 6
                        },
                        new
                        {
                            FoodItemId = 3,
                            IngredientId = 9
                        },
                        new
                        {
                            FoodItemId = 3,
                            IngredientId = 10
                        },
                        new
                        {
                            FoodItemId = 3,
                            IngredientId = 11
                        });
                });

            modelBuilder.Entity("Trackorie.Model.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            Calories = 717,
                            Description = "Butter is a dairy product made from the fat and protein components of churned cream. It is a semi-solid emulsion at room temperature, consisting of approximately 80% butterfat.",
                            Name = "Butter"
                        },
                        new
                        {
                            IngredientId = 2,
                            Calories = 399,
                            Description = "Golden caster sugar is a fine granulated sugar that is made from unrefined sugar cane or beets. It is popular in the UK for its colour, which is a pale golden brown, and it has a slightly buttery flavour. It is unfortunately fairly unique to the UK. The important point to make is that it is a dry, free-flowing sugar.",
                            Name = "Golden Caster Sugar"
                        },
                        new
                        {
                            IngredientId = 3,
                            Calories = 131,
                            Description = "Eggs are a natural source of many nutrients including high quality protein, vitamins and minerals.",
                            Name = "Egg"
                        },
                        new
                        {
                            IngredientId = 4,
                            Calories = 288,
                            Description = "Vanilla extract is a solution made by macerating and percolating vanilla pods in a solution of ethanol and water. It is considered an essential ingredient in many Western desserts, especially baked goods like cakes, cookies, brownies, and cupcakes, as well as custards, ice creams, and puddings. ",
                            Name = "Vanilla Extract"
                        },
                        new
                        {
                            IngredientId = 5,
                            Calories = 336,
                            Description = "Self-rising flour is flour with the baking powder and a bit of salt already added. ",
                            Name = "Self-Raising Flour"
                        },
                        new
                        {
                            IngredientId = 6,
                            Calories = 62,
                            Description = "Whole milk is sometimes referred to as “regular milk” because the amount of fat in it has not been altered.",
                            Name = "Whole Milk"
                        },
                        new
                        {
                            IngredientId = 7,
                            Calories = 884,
                            Description = "Sunflower oil is the non-volatile oil pressed from the seeds of the sunflower. Sunflower oil is commonly used in food as a frying oil, and in cosmetic formulations as an emollient. Sunflower oil is primarily composed of linoleic acid, a polyunsaturated fat, and oleic acid, a monounsaturated fat.",
                            Name = "Sunflower Oil"
                        },
                        new
                        {
                            IngredientId = 8,
                            Calories = 364,
                            Description = "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. \"Plain\" refers not only to middling gluten content but also to its lack of any added leavening agent (as in self-rising flour).",
                            Name = "Plain FLour"
                        },
                        new
                        {
                            IngredientId = 9,
                            Calories = 81,
                            Description = "Maris Pipers are readily available in supermarkets and greengrocers. The Maris Piper has a golden skin and creamy white flesh with a fluffy texture. This makes it a versatile all rounder, great for chips and roast potatoes, but also good for mash and wedges.",
                            Name = "Maris Piper Potato"
                        },
                        new
                        {
                            IngredientId = 10,
                            Calories = 884,
                            Description = "Olive oil is a liquid fat obtained from olives a traditional tree crop of the Mediterranean Basin, produced by pressing whole olives and extracting the oil.",
                            Name = "Olive Oil"
                        },
                        new
                        {
                            IngredientId = 11,
                            Calories = 0,
                            Description = "Sea salt is salt that is produced by the evaporation of seawater. It is used as a seasoning in foods, cooking, cosmetics and for preserving food. It is also called bay salt, solar salt, or simply salt",
                            Name = "Sea Salt"
                        });
                });

            modelBuilder.Entity("Trackorie.Model.FoodItemIngredient", b =>
                {
                    b.HasOne("Trackorie.Model.FoodItem", "FoodItem")
                        .WithMany("FoodItemIngredients")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trackorie.Model.Ingredient", "Ingredient")
                        .WithMany("FoodItemIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodItem");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Trackorie.Model.FoodItem", b =>
                {
                    b.Navigation("FoodItemIngredients");
                });

            modelBuilder.Entity("Trackorie.Model.Ingredient", b =>
                {
                    b.Navigation("FoodItemIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
