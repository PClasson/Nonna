using Nonna.Web.Models;

namespace Nonna.Web.Services
{
    public interface IRecipeService
    {
        List<Recipe> ListRecipes();
        Recipe FetchRecipe(Guid id);
    }

    public class RecipeService : IRecipeService
    {
        public List<Recipe> ListRecipes()
        {
            throw new NotImplementedException();
        }

        public Recipe FetchRecipe(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
