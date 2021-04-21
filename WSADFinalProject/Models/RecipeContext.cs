using Microsoft.EntityFrameworkCore;

namespace WSADFinalProject.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        { }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<RecipeCategory> RecipeCategorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>().HasKey(ba => new { ba.RecipeId, ba.IngredientId });

            modelBuilder.Entity<RecipeIngredient>().HasOne(ba => ba.Recipe)
                .WithMany(b => b.RecipeIngredients)
                .HasForeignKey(ba => ba.RecipeId);
            modelBuilder.Entity<RecipeIngredient>().HasOne(ba => ba.Ingredient)
                .WithMany(a => a.RecipeIngredients)
                .HasForeignKey(ba => ba.IngredientId);

            // Recipe: remove cascading delete with RecipeCategory
            modelBuilder.Entity<Recipe>().HasOne(b => b.RecipeCategory)
                .WithMany(g => g.Recipes)
                .OnDelete(DeleteBehavior.Restrict);

            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedRecipeCategorys());
            modelBuilder.ApplyConfiguration(new SeedRecipes());
            modelBuilder.ApplyConfiguration(new SeedIngredients());
            modelBuilder.ApplyConfiguration(new SeedRecipeIngredients());
        }
    }
}
