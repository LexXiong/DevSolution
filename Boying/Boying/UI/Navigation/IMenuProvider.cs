namespace Boying.UI.Navigation
{
    public interface IMenuProvider : IDependency
    {
        void GetMenu(object menu, NavigationBuilder builder);
    }
}