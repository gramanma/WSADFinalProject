namespace WSADFinalProject.Models
{
    public class RecipeIngredient
    {
        public int recipeId { get; set; }
        public int ingredientId { get; set; }
        public Recipe recipe { get; set; }
        public Ingredient ingredient { get; set; }
    }
}