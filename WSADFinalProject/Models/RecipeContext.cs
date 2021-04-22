using Microsoft.EntityFrameworkCore;

namespace WSADFinalProject.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RecipeIngredient>().HasKey(ri => new { ri.recipeId, ri.ingredientId });

            modelBuilder.Entity<RecipeIngredient>().HasOne(ri => ri.recipe)
                .WithMany(r => r.recipeIngredients)
                .HasForeignKey(ri => ri.recipeId);
            modelBuilder.Entity<RecipeIngredient>().HasOne(ri => ri.ingredient)
                .WithMany(i => i.recipeIngredients)
                .HasForeignKey(ri => ri.ingredientId);

            modelBuilder.ApplyConfiguration(new SeedRecipes());
            modelBuilder.ApplyConfiguration(new SeedIngredients());
            modelBuilder.ApplyConfiguration(new SeedRecipeIngredients());
        }
    }
}
