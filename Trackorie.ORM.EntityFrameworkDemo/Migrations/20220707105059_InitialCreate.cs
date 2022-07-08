using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trackorie.ORM.EntityFrameworkDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.FoodItemId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemIngredient",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemIngredient", x => new { x.FoodItemId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_FoodItemIngredient_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "FoodItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodItemIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Deleted", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Choose your favourite filling for this easy, perfectly fluffy sponge cake.", "Sponge Cake" },
                    { 2, null, "Foolproof easy crêpe recipe that ensures perfect pancakes every time – elaborate flip optional.", "Pancakes" },
                    { 3, null, "Achieve the perfect oven-roasted chips at home with a fluffy interior and crispy skin. These are much easier to cook and lower in fat than fried.", "Homemade Oven Chips" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Calories", "Deleted", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 717, null, "Butter is a dairy product made from the fat and protein components of churned cream. It is a semi-solid emulsion at room temperature, consisting of approximately 80% butterfat.", "Butter" },
                    { 2, 399, null, "Golden caster sugar is a fine granulated sugar that is made from unrefined sugar cane or beets. It is popular in the UK for its colour, which is a pale golden brown, and it has a slightly buttery flavour. It is unfortunately fairly unique to the UK. The important point to make is that it is a dry, free-flowing sugar.", "Golden Caster Sugar" },
                    { 3, 131, null, "Eggs are a natural source of many nutrients including high quality protein, vitamins and minerals.", "Egg" },
                    { 4, 288, null, "Vanilla extract is a solution made by macerating and percolating vanilla pods in a solution of ethanol and water. It is considered an essential ingredient in many Western desserts, especially baked goods like cakes, cookies, brownies, and cupcakes, as well as custards, ice creams, and puddings. ", "Vanilla Extract" },
                    { 5, 336, null, "Self-rising flour is flour with the baking powder and a bit of salt already added. ", "Self-Raising Flour" },
                    { 6, 62, null, "Whole milk is sometimes referred to as “regular milk” because the amount of fat in it has not been altered.", "Whole Milk" },
                    { 7, 884, null, "Sunflower oil is the non-volatile oil pressed from the seeds of the sunflower. Sunflower oil is commonly used in food as a frying oil, and in cosmetic formulations as an emollient. Sunflower oil is primarily composed of linoleic acid, a polyunsaturated fat, and oleic acid, a monounsaturated fat.", "Sunflower Oil" },
                    { 8, 364, null, "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds. \"Plain\" refers not only to middling gluten content but also to its lack of any added leavening agent (as in self-rising flour).", "Plain FLour" },
                    { 9, 81, null, "Maris Pipers are readily available in supermarkets and greengrocers. The Maris Piper has a golden skin and creamy white flesh with a fluffy texture. This makes it a versatile all rounder, great for chips and roast potatoes, but also good for mash and wedges.", "Maris Piper Potato" },
                    { 10, 884, null, "Olive oil is a liquid fat obtained from olives a traditional tree crop of the Mediterranean Basin, produced by pressing whole olives and extracting the oil.", "Olive Oil" },
                    { 11, 0, null, "Sea salt is salt that is produced by the evaporation of seawater. It is used as a seasoning in foods, cooking, cosmetics and for preserving food. It is also called bay salt, solar salt, or simply salt", "Sea Salt" }
                });

            migrationBuilder.InsertData(
                table: "FoodItemIngredient",
                columns: new[] { "FoodItemId", "IngredientId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 3 },
                    { 2, 6 },
                    { 2, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemIngredient_IngredientId",
                table: "FoodItemIngredient",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodItemIngredient");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
