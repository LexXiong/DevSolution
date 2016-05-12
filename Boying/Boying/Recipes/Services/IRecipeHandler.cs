using Boying.Recipes.Models;

namespace Boying.Recipes.Services
{
    public interface IRecipeHandler : IDependency
    {
        void ExecuteRecipeStep(RecipeContext recipeContext);
    }
}