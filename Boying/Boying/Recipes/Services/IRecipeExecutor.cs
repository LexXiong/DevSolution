using Boying.Recipes.Models;

namespace Boying.Recipes.Services
{
    public interface IRecipeExecutor : IDependency
    {
        string Execute(Recipe recipe);
    }
}