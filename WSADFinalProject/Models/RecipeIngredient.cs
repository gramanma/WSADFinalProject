namespace WSADFinalProject.Models
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public string IngredientQty {get; set; }
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
    }
}
