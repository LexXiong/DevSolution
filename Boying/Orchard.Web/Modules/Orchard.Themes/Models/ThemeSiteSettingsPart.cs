using Orchard.ContentManagement;

namespace Orchard.Themes.Models
{
    public class ThemeSiteSettingsPart
    {
        public virtual int Id { get; set; }

        public string CurrentThemeName { get; set; }
    }
}