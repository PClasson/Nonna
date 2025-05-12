namespace Nonna.Web.Models
{
    public class RecipeIndex
    {
        public List<RecipeSummary> Index { get; set; } = new();
    }

    public class RecipeSummary
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Path { get; set; }
        public List<string> Tags { get; set; } = [];
    }
}
