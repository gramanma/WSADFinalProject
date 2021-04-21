using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedRecipeIngredients : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> entity)
        {
            entity.HasData(
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, IngredientQty = "1" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 2, IngredientQty = "2" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, IngredientQty = "2" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 4, IngredientQty = "1" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 5, IngredientQty = "25g" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 6, IngredientQty = "2T" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 7, IngredientQty = "1" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 8, IngredientQty = "1" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 9, IngredientQty = "1l" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 10, IngredientQty = "100ml" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 11, IngredientQty = "3T" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 12, IngredientQty = "pinch" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 13, IngredientQty = "pinch" },

                new RecipeIngredient { RecipeId = 2, IngredientId = 14, IngredientQty = "225g" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 15, IngredientQty = "350g" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 16, IngredientQty = "85g" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 17, IngredientQty = "1.5t" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 18, IngredientQty = "1.5t" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 19, IngredientQty = "2" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 20, IngredientQty = "250ml" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 21, IngredientQty = "125ml" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 22, IngredientQty = "2t" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 23, IngredientQty = "250ml" }

            );
        }
    }

}
