using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    public class SeedRecipes : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> entity)
        {
            entity.HasData(
                new Recipe
                {
                    recipeID = 1,
                    recipeName = "Chocolate Cake",
                    recipeDesc = "baking, cake, chocolate",
                    recipePrepTime = "15 min",
                    recipeCookTime = "30 min",
                    Servings = 12,
                    Ingredients = "Flour, sugar...",
                    Method = "step 1: Preheat the oven to 170C..."

                },
                new Recipe
                {
                    recipeID = 2,
                    recipeName = "Cheese Burger",
                    recipeDesc = "grilling, burger, cheese",
                    recipePrepTime = "5 min",
                    recipeCookTime = "5 min",
                    Servings = 1,
                    Ingredients = "Cheese...",
                    Method = "step 1: turn on grill..."
                }
            );
        }
    }
}