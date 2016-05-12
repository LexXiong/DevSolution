using System.Xml.Linq;

namespace Boying.Recipes.Models
{
    public class RecipeBuilderStepConfigurationContext : ConfigurationContext
    {
        public RecipeBuilderStepConfigurationContext(XElement configurationElement) : base(configurationElement)
        {
        }
    }
}