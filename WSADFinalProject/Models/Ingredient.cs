using System.Collections.Generic;

namespace WSADFinalProject.Models
{
    public class Ingredient
    {
        public int ingredientID { get; set; }
        public string ingredientName { get; set; }
        
        public ICollection<RecipeIngredient> recipeIngredients {get; set; }
    }
}