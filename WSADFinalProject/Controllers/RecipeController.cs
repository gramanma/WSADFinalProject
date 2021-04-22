using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WSADFinalProject.Models;

namespace WSADFinalProject.Controllers 
{

    public class RecipeController : Controller 
    {
        private RecipeContext context;

        public RecipeController(RecipeContext ctx)
        {
            context = ctx;
        }
        public IActionResult RecipeDetails(int id)
        {
            
            List<Recipe> recipes = context.Recipes.OrderBy(r => r.recipeID).ToList();
            Recipe recipe = context.Recipes.Find(id);

            return View(recipe);
        }

        public IActionResult Recipes()
        {
            List<Recipe> recipes = context.Recipes.OrderBy(r => r.recipeID).ToList();
            
            return View(recipes);
        }
        
    }
}

