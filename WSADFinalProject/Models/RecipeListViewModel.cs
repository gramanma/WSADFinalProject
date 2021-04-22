using System.Collections.Generic;

namespace WSADFinalProject.Models
{
    public class RecipeListViewModel 
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<RecipeCategory> RecipeCategorys { get; set; }
        
    }
}
