using Microsoft.AspNetCore.Mvc;
using WSADFinalProject.Models;

namespace WSADFinalProject.Controllers
{
    public class IngredientController : Controller
    {
        private Repository<Ingredient> data { get; set; }
        public IngredientController(RecipeContext ctx) => data = new Repository<Ingredient>(ctx);

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List()
        {

            var options = new QueryOptions<Ingredient> {
                Includes = "RecipeIngredients.Recipe"
            };

            var vm = new IngredientListViewModel {
                Ingredients = data.List(options)
            };

            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var Ingredient = data.Get(new QueryOptions<Ingredient> {
                Includes = "RecipeIngredients.Recipe",
                Where = i => i.IngredientId == id
            });
            return View(Ingredient);
        }
    }
}