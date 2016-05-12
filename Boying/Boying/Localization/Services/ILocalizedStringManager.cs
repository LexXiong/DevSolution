namespace Boying.Localization.Services
{
    public interface ILocalizedStringManager : IDependency
    {
        string GetLocalizedString(string scope, string text, string cultureName);
    }
}