
namespace WSADFinalProject.Models
{
    public class RecipeUnitOfWork : IRecipeUnitOfWork
    {
        private RecipeContext context { get; set; }
        public RecipeUnitOfWork(RecipeContext ctx) => context = ctx;

        private Repository<Recipe> RecipeData;
        public Repository<Recipe> Recipes {
            get {
                if (RecipeData == null)
                    RecipeData = new Repository<Recipe>(context);
                return RecipeData;
            }
        }

        private Repository<Ingredient> IngredientData;
        public Repository<Ingredient> Ingredients {
            get {
                if (IngredientData == null)
                    IngredientData = new Repository<Ingredient>(context);
                return IngredientData;
            }
        }

        private Repository<RecipeIngredient> RecipeIngredientData;
        public Repository<RecipeIngredient> RecipeIngredients {
            get {
                if (RecipeIngredientData == null)
                    RecipeIngredientData = new Repository<RecipeIngredient>(context);
                return RecipeIngredientData;
            }
        }

        private Repository<RecipeCategory> RecipeCategoryData;
        public Repository<RecipeCategory> RecipeCategorys
        {
            get {
                if (RecipeCategoryData == null)
                    RecipeCategoryData = new Repository<RecipeCategory>(context);
                return RecipeCategoryData;
            }
        }

        public void DeleteCurrentRecipeIngredients(Recipe Recipe)
        {
            var currentIngredients = RecipeIngredients.List(new QueryOptions<RecipeIngredient> {
                Where = ri => ri.RecipeId == Recipe.RecipeId
            });
            foreach (RecipeIngredient ri in currentIngredients) {
                RecipeIngredients.Delete(ri);
            }
        }

        public void AddNewRecipeIngredients(Recipe Recipe, int[] Ingredientids)
        {
            foreach (int id in Ingredientids)
            {
                RecipeIngredient ri =
                    new RecipeIngredient { RecipeId = Recipe.RecipeId, IngredientId = id };
                RecipeIngredients.Insert(ri);
            }
        }

        public void Save() => context.SaveChanges();
    }
}