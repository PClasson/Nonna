namespace Nonna.Web.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<IngredientSection> IngredientSections { get; set; } = [];
        public List<StepSection> StepSections { get; set; } = [];
        public List<string> Notes { get; set; } = [];
        public List<string> Tags { get; set; } = [];
        public string Image { get; set; }
    }

    public class IngredientSection
    {
        public string Title { get; set; }
        public List<string> Ingredients { get; set; } = [];
    }

    public class StepSection
    {
        public string Title { get; set; }
        public List<string> Steps { get; set; } = [];
    }
}
