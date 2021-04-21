using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WSADFinalProject.Models
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDesc { get; set; }
        public string RecipePrepTime { get; set; }
        public string RecipeCookTime { get; set; }
        public string RecipeServings { get; set; }
        public string RecipeMethod { get; set; }
        public string RecipeCategoryId { get; set; }

        public RecipeCategory RecipeCategory { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
