namespace WSADFinalProject.Models
{
    public interface IRecipeUnitOfWork
    {
        Repository<Recipe> Recipes { get; }
        Repository<Ingredient> Ingredients { get; }
        Repository<RecipeIngredient> RecipeIngredients { get; }
        Repository<RecipeCategory> RecipeCategorys { get; }

        void DeleteCurrentRecipeIngredients(Recipe Recipe);
        void AddNewRecipeIngredients(Recipe Recipe, int[] Ingredientids);
        void Save();
    }
}
