namespace WSADFinalProject.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public int Servings { get; set; }
        public string Ingredients { get; set; }
        public string Method { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}