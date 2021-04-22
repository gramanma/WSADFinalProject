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
                    { 31, "tomato" },
                    { 30, "lettuce" },
                    { 29, "mayonnaise" },
                    { 28, "bread" },
                    { 27, "chicken breast" },
                    { 26, "bacon" },
                    { 25, "ham" },
                    { 24, "cheddar cheese" },
                    { 23, "water" },
                    { 22, "vanilla" },
                    { 20, "milk" },
                    { 19, "eggs" },
                    { 18, "bicarbonate of soda" },
                    { 17, "cocoa powder" },
                    { 21, "vegetable oil" },
                    { 15, "caster sugar" },
                    { 2, "carrots" },
                    { 3, "garlic cloves" },
                    { 16, "baking powder" },
                    { 5, "butter" },
                    { 6, "olive oil" },
                    { 7, "pumpkin" },
                    { 8, "potato" },
                    { 4, "bay leaf" },
                    { 10, "double cream" },
                    { 11, "pumpkin seeds" },
                    { 12, "salt" },
                    { 13, "pepper" },
                    { 14, "plain flour" },
                    { 9, "chicken stock" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategorys",
                columns: new[] { "RecipeCategoryId", "RecipeCategoryName" },
                values: new object[,]
                {
                    { "desserts", "Desserts" },
                    { "mandishes", "Main dishes" },
                    { "salads", "Salads" },
                    { "sandwich", "Sandwiches" },
                    { "beverages", "Beverages" },
                    { "appetizers", "Appetizers" },
                    { "lunch", "Lunch" },
                    { "breakfast", "Breakfast" },
                    { "bread", "Bread" },
                    { "soups", "Soups" },
                    { "vegetarian", "Vegetarian" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "RecipeCategoryId", "RecipeCookTime", "RecipeDesc", "RecipeMethod", "RecipeName", "RecipePrepTime", "RecipeServings" },
                values: new object[,]
                {
                    { 3, "breakfast", "less than 10 mins", "Try this classic omelette for brunch or serve with lots of green salad for a quick and satisfying dinner.", "Gently beat the eggs together in a mixing bowl and season, to taste, with salt and pepper. Heat the butter in a frying pan until foaming. Pour in the eggs and cook for a few seconds, until the bottom of the omelette is lightly set. Push the set parts of the omelette into the uncooked centre of the omelette. Cook again, until the omelette has set further, then push those set parts into the centre of the omelette again. Repeat the process until the eggs have just set but the omelette is still soft in the centre. Put the cheese and three-quarters of the ham in the centre of the omelette and cook until the cheese has melted. Increase the heat to high and cook the omelette for a further 30 seconds, or until it browns on the bottom. Fold the omelette in half, then remove the pan from the heat and tilt it slightly to move the omelette to the edge of the pan. Slide the omelette onto a serving plate, then shape it into a neat roll. Sprinkle over the remaining ham.", "Cheese and ham omelette", "less than 30 mins", "Serves 1" },
                    { 1, "soups", "30 mins to 1 hour", "You need to have this delightfully warming pumpkin soup in your little black book of dinners. Serve with a swirl of cream.", @"Put the onion, carrots, garlic bay leaf, butter and half the olive oil into a large pan. Cook over a low–medium heat for about 10 minutes until the vegetables are tender but not coloured. 
                 Add the squash and potato, mix to combine and cook for a further 2–3 minutes. Pour in the stock, season well and bring to the boil. Reduce the heat to a gentle simmer, half cover the pan with a lid and continue to cook for about 40 minutes until the squash is really tender when tested with the point of a knife. 
                 Pick out the bay leaf and blend the soup until smooth using a stick blender. 
                 Add the cream and a little more stock if the soup is on the thick side, taste for seasoning, adding more salt and pepper as required. 
                 Meanwhile, heat the remaining oil in a frying pan over a medium heat and add the pumpkin seeds and fry quickly until the seeds start to pop. Remove from the pan. 
                 Ladle the soup into bowls and serve with a swirl of cream and the toasted pumpkin seeds.", "Pumpkin Soup", "less than 30 mins", "Serves 6–8" },
                    { 4, "sandwich", "10 to 30 minss", "A club sandwich is a thing of beauty. You can fancy it up with extra fillings like avocado, mustard, thinly sliced red onion, but you can also keep it simple. This double layer sandwich is definitely filling enough for dinner with a side of soup or some crispy chips.", "Heat a frying pan over a medium heat. Add a drizzle of oil, then the bacon slices to the pan and fry for 5–10 minutes, turning the bacon every so often, until it is crisp and browned all over. Transfer to a plate lined with kitchen paper. Slice the chicken breast horizontally in two, so you have two thinner pieces. Season with salt and pepper, then fry the chicken in the hot bacon fat over a medium–high heat until they are browned and completely cooked through. Meanwhile, toast the bread to your liking. Spread each slice with a teaspoon of mayonnaise. Build the sandwich by adding lettuce leaves and tomato slices to the bottom piece of toast, season with salt and black pepper, then top with a slice of the crisp hot bacon. Slice each large piece of chicken breast into 4 or 5 equal pieces on a diagonal so they are easy to spread across the sandwich. Place the second piece of toast on top, then repeat the layering again finishing with the final piece of toast. Cut the sandwich diagonally in both directions to create 4 triangles, securing each with a cocktail stick.", "Club Sandwich", "less than 30 mins", "Serves 1" },
                    { 2, "desserts", "30 mins to 1 hour", "Our really easy chocolate cake recipe is moist and fudgy and will keep well for 4–5 days.", @"Preheat the oven to 180C/160C Fan/Gas 4. Grease and line two 20cm/8in sandwich tins.
                 For the cake, place all of the cake ingredients, except the boiling water, into a large mixing bowl. Using a wooden spoon, or electric whisk, beat the mixture until smooth and well combined. 
                 Add the boiling water to the mixture, a little at a time, until smooth. (The cake mixture will now be very liquid.) 
                 Divide the cake batter between the sandwich tins and bake in the oven for 25–35 minutes, or until the top is firm to the touch and a skewer inserted into the centre of the cake comes out clean. 
                 Remove the cakes from the oven and allow to cool completely, still in their tins, before icing. 
                 For the chocolate icing, heat the chocolate and cream in a saucepan over a low heat until the chocolate melts. Remove the pan from the heat and whisk the mixture until smooth, glossy and thickened. Set aside to cool for 1–2 hours, or until thick enough to spread over the cake. 
                 To assemble the cake, run a round-bladed knife around the inside of the cake tins to loosen the cakes. Carefully remove the cakes from the tins. 
                 Spread a little chocolate icing over the top of one of the chocolate cakes, then carefully top with the other cake. 
                 Transfer the cake to a serving plate and ice the cake all over with the chocolate icing, using a palette knife.", "Chocolate Cake", "less than 30 mins", "Serves 12" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeId", "IngredientId", "IngredientQty" },
                values: new object[,]
                {
                    { 3, 5, "10g" },
                    { 4, 26, "2 slices" },
                    { 4, 27, "1" },
                    { 4, 28, "3 slices" },
                    { 4, 29, "1T" },
                    { 4, 30, "handful" },
                    { 4, 31, "1 sliced" },
                    { 1, 13, "pinch" },
                    { 2, 14, "225g" },
                    { 2, 16, "85g" },
                    { 2, 17, "1.5t" },
                    { 2, 18, "1.5t" },
                    { 2, 19, "2" },
                    { 2, 20, "250ml" },
                    { 2, 21, "125ml" },
                    { 2, 15, "350g" },
                    { 2, 22, "2t" },
                    { 1, 12, "pinch" },
                    { 1, 10, "100ml" },
                    { 3, 12, "pinch" },
                    { 3, 13, "pinch" },
                    { 3, 19, "3" },
                    { 3, 24, "30g" },
                    { 3, 25, "1 slice" },
                    { 1, 1, "1" },
                    { 1, 11, "3T" },
                    { 1, 2, "2" },
                    { 1, 4, "1" },
                    { 1, 5, "25g" },
                    { 1, 6, "2T" },
                    { 1, 7, "1" },
                    { 1, 8, "1" },
                    { 1, 9, "1l" },
                    { 1, 3, "2" },
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
