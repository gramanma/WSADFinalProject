using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedIngredients : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> entity)
        {
            entity.HasData(

                new Ingredient { IngredientId = 1, IngredientName = "onion" },
                new Ingredient { IngredientId = 2, IngredientName = "carrots" },
                new Ingredient { IngredientId = 3, IngredientName = "garlic cloves" },
                new Ingredient { IngredientId = 4, IngredientName = "bay leaf" },
                new Ingredient { IngredientId = 5, IngredientName = "butter" },
                new Ingredient { IngredientId = 6, IngredientName = "olive oil" },
                new Ingredient { IngredientId = 7, IngredientName = "pumpkin" },
                new Ingredient { IngredientId = 8, IngredientName = "potato" },
                new Ingredient { IngredientId = 9, IngredientName = "chicken stock" },
                new Ingredient { IngredientId = 10, IngredientName = "double cream" },
                new Ingredient { IngredientId = 11, IngredientName = "pumpkin seeds" },
                new Ingredient { IngredientId = 12, IngredientName = "salt" },
                new Ingredient { IngredientId = 13, IngredientName = "pepper" },
                new Ingredient { IngredientId = 14, IngredientName = "plain flour" },
                new Ingredient { IngredientId = 15, IngredientName = "caster sugar" },
                new Ingredient { IngredientId = 16, IngredientName = "baking powder" },
                new Ingredient { IngredientId = 17, IngredientName = "cocoa powder" },
                new Ingredient { IngredientId = 18, IngredientName = "bicarbonate of soda" },
                new Ingredient { IngredientId = 19, IngredientName = "eggs" },
                new Ingredient { IngredientId = 20, IngredientName = "milk" },
                new Ingredient { IngredientId = 21, IngredientName = "vegetable oil" },
                new Ingredient { IngredientId = 22, IngredientName = "vanilla" },
                new Ingredient { IngredientId = 23, IngredientName = "water" },
                new Ingredient { IngredientId = 24, IngredientName = "cheddar cheese" },
                new Ingredient { IngredientId = 25, IngredientName = "ham" },
                new Ingredient { IngredientId = 26, IngredientName = "bacon" },
                new Ingredient { IngredientId = 27, IngredientName = "chicken breast" },
                new Ingredient { IngredientId = 28, IngredientName = "bread" },
                new Ingredient { IngredientId = 29, IngredientName = "mayonnaise" },
                new Ingredient { IngredientId = 30, IngredientName = "lettuce" },
                new Ingredient { IngredientId = 31, IngredientName = "tomato" }
            );
        }
    }

}