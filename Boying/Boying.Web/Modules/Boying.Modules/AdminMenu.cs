﻿using Boying.Localization;
using Boying.Security;
using Boying.UI.Navigation;

namespace Boying.Modules
{
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }

        public string MenuName
        {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("modules")
                .Add(T("Modules"), "9", menu => menu.Action("Features", "Admin", new { area = "Boying.Modules" }).Permission(Permissions.ManageFeatures)
                    .Add(T("Features"), "0", item => item.Action("Features", "Admin", new { area = "Boying.Modules" }).Permission(Permissions.ManageFeatures).LocalNav())
                    .Add(T("Installed"), "1", item => item.Action("Index", "Admin", new { area = "Boying.Modules" }).Permission(StandardPermissions.SiteOwner).LocalNav())
                    .Add(T("Recipes"), "2", item => item.Action("Recipes", "Admin", new { area = "Boying.Modules" }).Permission(StandardPermissions.SiteOwner).LocalNav())
                    );
        }
    }
}