using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedRecipeIngredients : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> entity)
        {
            entity.HasData(
                new RecipeIngredient
                {
                    recipeId = 1,
                    ingredientId = 1
                },  
                new RecipeIngredient
                {
                    recipeId = 1,
                    ingredientId = 2
                }  
            );
        }
    }
}