using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WSADFinalProject.Models
{
    public class RecipeCategory
    {
        public string RecipeCategoryId { get; set; }

        public string RecipeCategoryName { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}