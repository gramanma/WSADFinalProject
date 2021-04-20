using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WSADFinalProject.Models;

namespace WSADFinalProject.Controllers 
{

    public class RecipeController : Controller 
    {
        public IActionResult RecipeDetails(string id)
        {
            Recipe recipe = DB.GetRecipe(id);
            return View(recipe);
        }

        public IActionResult Recipes()
        {
            List<Recipe> recipes = DB.GetRecipes();
            return View(recipes);
        }
    }
}

