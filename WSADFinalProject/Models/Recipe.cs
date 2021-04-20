using System.Collections.Generic;

namespace WSADFinalProject.Models
{
    public class Recipe
    {
        public int recipeID { get; set; }
        public string recipeName { get; set; }
        public string recipeDesc { get; set; }
        public string recipePrepTime { get; set; }
        public string recipeCookTime { get; set; }
        public int Servings { get; set; }
        public string Ingredients { get; set; }
        public string Method { get; set; }
        public string Slug => recipeName.Replace(' ', '-');

        public ICollection<RecipeIngredient> recipeIngredients {get; set; }
    }
}