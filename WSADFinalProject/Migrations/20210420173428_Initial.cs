using Microsoft.EntityFrameworkCore.Migrations;

namespace WSADFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    ingredientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredientName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.ingredientID);
                });

            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    recipeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipeName = table.Column<string>(nullable: true),
                    recipeDesc = table.Column<string>(nullable: true),
                    recipePrepTime = table.Column<string>(nullable: true),
                    recipeCookTime = table.Column<string>(nullable: true),
                    Servings = table.Column<int>(nullable: false),
                    Ingredients = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.recipeID);
                });

            migrationBuilder.CreateTable(
                name: "recipeIngredients",
                columns: table => new
                {
                    recipeId = table.Column<int>(nullable: false),
                    ingredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipeIngredients", x => new { x.recipeId, x.ingredientId });
                    table.ForeignKey(
                        name: "FK_recipeIngredients_ingredients_ingredientId",
                        column: x => x.ingredientId,
                        principalTable: "ingredients",
                        principalColumn: "ingredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recipeIngredients_recipes_recipeId",
                        column: x => x.recipeId,
                        principalTable: "recipes",
                        principalColumn: "recipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "recipes",
                columns: new[] { "recipeID", "Ingredients", "Method", "Servings", "recipeCookTime", "recipeDesc", "recipeName", "recipePrepTime" },
                values: new object[] { 1, "Flour, sugar...", "step 1: Preheat the oven to 170C...", 12, "30 min", "baking, cake, chocolate", "Chocolate Cake", "15 min" });

            migrationBuilder.InsertData(
                table: "recipes",
                columns: new[] { "recipeID", "Ingredients", "Method", "Servings", "recipeCookTime", "recipeDesc", "recipeName", "recipePrepTime" },
                values: new object[] { 2, "Cheese...", "step 1: turn on grill...", 1, "5 min", "grilling, burger, cheese", "Cheese Burger", "5 min" });

            migrationBuilder.CreateIndex(
                name: "IX_recipeIngredients_ingredientId",
                table: "recipeIngredients",
                column: "ingredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipeIngredients");

            migrationBuilder.DropTable(
                name: "ingredients");

            migrationBuilder.DropTable(
                name: "recipes");
        }
    }
}
