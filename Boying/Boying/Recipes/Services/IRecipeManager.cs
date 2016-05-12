using Boying.Recipes.Models;

namespace Boying.Recipes.Services
{
    public interface IRecipeManager : IDependency
    {
        string Execute(Recipe recipe);
    }
}