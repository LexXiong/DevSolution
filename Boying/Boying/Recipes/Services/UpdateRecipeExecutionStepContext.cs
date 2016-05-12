using System.Xml.Linq;

namespace Boying.Recipes.Services
{
    public class UpdateRecipeExecutionStepContext
    {
        public XDocument RecipeDocument { get; set; }

        public XElement Step { get; set; }
    }
}