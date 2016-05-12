using Boying.Events;

namespace Boying.Recipes.Events
{
    public interface IRecipeSchedulerEventHandler : IEventHandler
    {
        void ExecuteWork(string executionId);
    }
}