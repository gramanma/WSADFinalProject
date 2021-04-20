using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedIngredients : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> entity)
        {
            entity.HasData(
              new Ingredient
                {
                    ingredientID = 1,
                    ingredientName = "flour"

                },
                new Ingredient
                {
                    ingredientID = 2,
                    ingredientName = "sugar"
                }  
            );
        }
    }
}