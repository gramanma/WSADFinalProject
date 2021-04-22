
using Microsoft.AspNetCore.Mvc;
using WSADFinalProject.Models;

namespace WSADFinalProject.Controllers
{
    public class RecipeController : Controller
    {
        private RecipeUnitOfWork data { get; set; }
        public RecipeController(RecipeContext ctx) => data = new RecipeUnitOfWork(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List");
        public ViewResult List()
        {

            var vm = new RecipeListViewModel {
                Recipes = data.Recipes.List(new QueryOptions<Recipe> {
                    OrderBy = r => r.RecipeName }),
                Ingredients = data.Ingredients.List(new QueryOptions<Ingredient> {
                    OrderBy = i => i.IngredientName }),
                RecipeCategorys = data.RecipeCategorys.List(new QueryOptions<RecipeCategory> {
                    OrderBy = c => c.RecipeCategoryName })
            };

            return View(vm);
        }

        public ViewResult Details(int id)
        {
            var Recipe = data.Recipes.Get(new QueryOptions<Recipe> {
                Includes = "RecipeIngredients.Ingredient, RecipeCategory",
                Where = r => r.RecipeId == id
            });
            return View(Recipe);
        }
    }   
}
