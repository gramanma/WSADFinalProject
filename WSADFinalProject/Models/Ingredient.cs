using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace WSADFinalProject.Models
{
    public class Ingredient
    {

        public int IngredientId { get; set; }

        public string IngredientName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
