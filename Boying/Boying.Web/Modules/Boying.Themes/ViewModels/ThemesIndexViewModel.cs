using System.Collections.Generic;
using Boying.Themes.Models;

namespace Boying.Themes.ViewModels {
    public class ThemesIndexViewModel {
        public bool InstallThemes { get; set; }
        public ThemeEntry CurrentTheme { get; set; }
        public IEnumerable<ThemeEntry> Themes { get; set; }
    }
}