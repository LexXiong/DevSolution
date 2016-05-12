using Boying.Localization;
using Boying.UI.Navigation;

namespace Boying.Themes {
    public class AdminMenu : INavigationProvider {
        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder) {
            builder.AddImageSet("themes")
                .Add(T("Themes"), "10", menu => menu.Action("Index", "Admin", new { area = "Boying.Themes" }).Permission(Permissions.ApplyTheme)
                    .Add(T("Installed"), "0", item => item.Action("Index", "Admin", new { area = "Boying.Themes" }).Permission(Permissions.ApplyTheme).LocalNav()));
        }
    }
}