using System.Collections.Generic;

namespace WSADFinalProject.Models
{
    public class DB
    {
        public static List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe
                {
                    RecipeID = 1,
                    Name = "Cake",
                    Time = "1 hr",
                    Servings = 12,
                    Ingredients = "Flour, sugar...",
                    Method = "step 1: Preheat the oven to 170C..."

                },
                new Recipe
                {
                    RecipeID = 2,
                    Name = "Burger",
                    Time = "10 min",
                    Servings = 1,
                    Ingredients = "Cheese...",
                    Method = "step 1: turn on grill..."
                }
            };
            return recipes;
        }

        public static Recipe GetRecipe(string slug)
        {
            List<Recipe> recipes = DB.GetRecipes();
            foreach (Recipe r in recipes)
            {
                if (r.Slug == slug)
                {
                    return r;
                }
            }
            return null;
        }
    }
}