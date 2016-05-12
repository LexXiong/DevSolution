using Boying.Recipes.Models;

namespace Boying.Recipes.Services
{
    public interface IRecipeStepQueue : ISingletonDependency
    {
        void Enqueue(string executionId, RecipeStep step);

        RecipeStep Dequeue(string executionId);
    }
}