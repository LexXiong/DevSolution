using System.Collections.Generic;
using Boying.Environment.Extensions.Models;

namespace Boying.Themes.Services
{
    public interface IThemeService : IDependency
    {
        void DisableThemeFeatures(string themeName);

        void EnableThemeFeatures(string themeName);

        bool IsRecentlyInstalled(ExtensionDescriptor module);

        void DisablePreviewFeatures(IEnumerable<string> features);
    }
}