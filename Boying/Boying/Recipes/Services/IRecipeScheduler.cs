namespace Boying.Recipes.Services
{
    public interface IRecipeScheduler : IDependency
    {
        void ScheduleWork(string executionId);
    }
}