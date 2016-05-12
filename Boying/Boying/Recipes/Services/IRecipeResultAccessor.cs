using Boying.Recipes.Models;

namespace Boying.Recipes.Services
{
    /// <summary>
    /// Provides information about the result of recipe execution.
    /// </summary>
    public interface IRecipeResultAccessor : IDependency
    {
        RecipeResult GetResult(string executionId);
    }
}