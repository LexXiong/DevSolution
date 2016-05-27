using Boying.ContentManagement;
using Boying.Data;

namespace Boying.Themes.Models
{
    public class ThemeSiteSettingsRecord
    {
        public virtual int Id { get; set; }

        public string CurrentThemeName { get; set; }
    }
}