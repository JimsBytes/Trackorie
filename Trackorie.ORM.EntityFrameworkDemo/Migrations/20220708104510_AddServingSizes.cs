using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trackorie.ORM.EntityFrameworkDemo.Migrations
{
    public partial class AddServingSizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaloriesUnit",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "FoodItemIngredient",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "FoodItemIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 225.0, 3 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 225.0, 3 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 3 },
                column: "Amount",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 225.0, 3 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 20.0, 6 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 2, 3 },
                column: "Amount",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 300.0, 6 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 100.0, 3 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 1.6000000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "FoodItemIngredient",
                keyColumns: new[] { "FoodItemId", "IngredientId" },
                keyValues: new object[] { 3, 11 },
                columns: new[] { "Amount", "Unit" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10,
                column: "CaloriesUnit",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11,
                column: "CaloriesUnit",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriesUnit",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "FoodItemIngredient");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "FoodItemIngredient");
        }
    }
}
