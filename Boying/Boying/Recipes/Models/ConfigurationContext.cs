using System.Xml.Linq;

namespace Boying.Recipes.Models
{
    public class ConfigurationContext
    {
        protected ConfigurationContext(XElement configurationElement)
        {
            ConfigurationElement = configurationElement;
        }

        public XElement ConfigurationElement { get; set; }
    }
}