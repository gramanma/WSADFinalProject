using Microsoft.EntityFrameworkCore.Migrations;

namespace WSADFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ingredientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredientName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ingredientID);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    recipeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipePrepTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipeCookTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.recipeID);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    recipeId = table.Column<int>(type: "int", nullable: false),
                    ingredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.recipeId, x.ingredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_ingredientId",
                        column: x => x.ingredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ingredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_recipeId",
                        column: x => x.recipeId,
                        principalTable: "Recipes",
                        principalColumn: "recipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ingredientID", "ingredientName" },
                values: new object[,]
                {
                    { 1, "flour" },
                    { 2, "sugar" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "recipeID", "Ingredients", "Method", "Servings", "recipeCookTime", "recipeDesc", "recipeName", "recipePrepTime" },
                values: new object[,]
                {
                    { 1, "Flour, sugar...", "step 1: Preheat the oven to 170C...", 12, "30 min", "baking, cake, chocolate", "Chocolate Cake", "15 min" },
                    { 2, "Cheese...", "step 1: turn on grill...", 1, "5 min", "grilling, burger, cheese", "Cheese Burger", "5 min" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "ingredientId", "recipeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "ingredientId", "recipeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_ingredientId",
                table: "RecipeIngredients",
                column: "ingredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
