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
                    IngredientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategorys",
                columns: table => new
                {
                    RecipeCategoryId = table.Column<string>(nullable: false),
                    RecipeCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategorys", x => x.RecipeCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(nullable: true),
                    RecipeDesc = table.Column<string>(nullable: true),
                    RecipePrepTime = table.Column<string>(nullable: true),
                    RecipeCookTime = table.Column<string>(nullable: true),
                    RecipeServings = table.Column<string>(nullable: true),
                    RecipeMethod = table.Column<string>(nullable: true),
                    RecipeCategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_RecipeCategorys_RecipeCategoryId",
                        column: x => x.RecipeCategoryId,
                        principalTable: "RecipeCategorys",
                        principalColumn: "RecipeCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false),
                    IngredientQty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName" },
                values: new object[,]
                {
                    { 1, "onion" },
                    { 23, "water" },
                    { 22, "vanilla" },
                    { 21, "vegetable oil" },
                    { 20, "milk" },
                    { 19, "eggs" },
                    { 18, "bicarbonate of soda" },
                    { 16, "baking powder" },
                    { 15, "caster sugar" },
                    { 14, "plain flour" },
                    { 13, "pepper" },
                    { 17, "cocoa powder" },
                    { 11, "pumpkin seeds" },
                    { 12, "salt" },
                    { 3, "garlic cloves" },
                    { 4, "bay leaf" },
                    { 5, "butter" },
                    { 6, "olive oil" },
                    { 2, "carrots" },
                    { 8, "potato" },
                    { 9, "chicken stock" },
                    { 10, "double cream" },
                    { 7, "pumpkin" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategorys",
                columns: new[] { "RecipeCategoryId", "RecipeCategoryName" },
                values: new object[,]
                {
                    { "bread", "Bread" },
                    { "breakfast", "Breakfast" },
                    { "lunch", "Lunch" },
                    { "beverages", "Beverages" },
                    { "appetizers", "Appetizers" },
                    { "soups", "Soups" },
                    { "salads", "Salads" },
                    { "mandishes", "Main dishes" },
                    { "desserts", "Desserts" },
                    { "vegetarian", "Vegetarian" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "RecipeCategoryId", "RecipeCookTime", "RecipeDesc", "RecipeMethod", "RecipeName", "RecipePrepTime", "RecipeServings" },
                values: new object[] { 1, "soups", "30 mins to 1 hour", "You need to have this delightfully warming pumpkin soup in your little black book of dinners. Serve with a swirl of cream.", @"Put the onion, carrots, garlic bay leaf, butter and half the olive oil into a large pan. Cook over a low–medium heat for about 10 minutes until the vegetables are tender but not coloured. 
 Add the squash and potato, mix to combine and cook for a further 2–3 minutes. Pour in the stock, season well and bring to the boil. Reduce the heat to a gentle simmer, half cover the pan with a lid and continue to cook for about 40 minutes until the squash is really tender when tested with the point of a knife. 
 Pick out the bay leaf and blend the soup until smooth using a stick blender. 
 Add the cream and a little more stock if the soup is on the thick side, taste for seasoning, adding more salt and pepper as required. 
 Meanwhile, heat the remaining oil in a frying pan over a medium heat and add the pumpkin seeds and fry quickly until the seeds start to pop. Remove from the pan. 
 Ladle the soup into bowls and serve with a swirl of cream and the toasted pumpkin seeds.", "Pumpkin Soup", "less than 30 mins", "Serves 6–8" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "RecipeCategoryId", "RecipeCookTime", "RecipeDesc", "RecipeMethod", "RecipeName", "RecipePrepTime", "RecipeServings" },
                values: new object[] { 2, "desserts", "30 mins to 1 hour", "Our really easy chocolate cake recipe is moist and fudgy and will keep well for 4–5 days.", @"Preheat the oven to 180C/160C Fan/Gas 4. Grease and line two 20cm/8in sandwich tins.
 For the cake, place all of the cake ingredients, except the boiling water, into a large mixing bowl. Using a wooden spoon, or electric whisk, beat the mixture until smooth and well combined. 
 Add the boiling water to the mixture, a little at a time, until smooth. (The cake mixture will now be very liquid.) 
 Divide the cake batter between the sandwich tins and bake in the oven for 25–35 minutes, or until the top is firm to the touch and a skewer inserted into the centre of the cake comes out clean. 
 Remove the cakes from the oven and allow to cool completely, still in their tins, before icing. 
 For the chocolate icing, heat the chocolate and cream in a saucepan over a low heat until the chocolate melts. Remove the pan from the heat and whisk the mixture until smooth, glossy and thickened. Set aside to cool for 1–2 hours, or until thick enough to spread over the cake. 
 To assemble the cake, run a round-bladed knife around the inside of the cake tins to loosen the cakes. Carefully remove the cakes from the tins. 
 Spread a little chocolate icing over the top of one of the chocolate cakes, then carefully top with the other cake. 
 Transfer the cake to a serving plate and ice the cake all over with the chocolate icing, using a palette knife.", "Chocolate Cake", "less than 30 mins", "Serves 12" });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeId", "IngredientId", "IngredientQty" },
                values: new object[,]
                {
                    { 1, 1, "1" },
                    { 2, 21, "125ml" },
                    { 2, 20, "250ml" },
                    { 2, 19, "2" },
                    { 2, 18, "1.5t" },
                    { 2, 17, "1.5t" },
                    { 2, 16, "85g" },
                    { 2, 15, "350g" },
                    { 2, 14, "225g" },
                    { 1, 13, "pinch" },
                    { 2, 22, "2t" },
                    { 1, 12, "pinch" },
                    { 1, 10, "100ml" },
                    { 1, 9, "1l" },
                    { 1, 8, "1" },
                    { 1, 7, "1" },
                    { 1, 6, "2T" },
                    { 1, 5, "25g" },
                    { 1, 4, "1" },
                    { 1, 3, "2" },
                    { 1, 2, "2" },
                    { 1, 11, "3T" },
                    { 2, 23, "250ml" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RecipeCategoryId",
                table: "Recipes",
                column: "RecipeCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "RecipeCategorys");
        }
    }
}
