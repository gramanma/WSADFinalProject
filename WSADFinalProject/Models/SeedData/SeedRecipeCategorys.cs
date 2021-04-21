using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedRecipeCategorys : IEntityTypeConfiguration<RecipeCategory>
    {
        public void Configure(EntityTypeBuilder<RecipeCategory> entity)
        {
            entity.HasData(

                new RecipeCategory { RecipeCategoryId = "breakfast", RecipeCategoryName = "Breakfast" },
                new RecipeCategory { RecipeCategoryId = "lunch", RecipeCategoryName = "Lunch" },
                new RecipeCategory { RecipeCategoryId = "beverages", RecipeCategoryName = "Beverages" },
                new RecipeCategory { RecipeCategoryId = "appetizers", RecipeCategoryName = "Appetizers" },
                new RecipeCategory { RecipeCategoryId = "soups", RecipeCategoryName = "Soups" },
                new RecipeCategory { RecipeCategoryId = "salads", RecipeCategoryName = "Salads" },
                new RecipeCategory { RecipeCategoryId = "mandishes", RecipeCategoryName = "Main dishes" },
                new RecipeCategory { RecipeCategoryId = "desserts", RecipeCategoryName = "Desserts" },
                new RecipeCategory { RecipeCategoryId = "bread", RecipeCategoryName = "Bread" },
                new RecipeCategory { RecipeCategoryId = "vegetarian", RecipeCategoryName = "Vegetarian" }
            );
        }
    }

}
