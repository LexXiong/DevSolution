using System.Collections.Generic;
using Boying.Modules.Models;
using Boying.Recipes.Models;

namespace Boying.Modules.ViewModels
{
    public class RecipesViewModel
    {
        public IEnumerable<ModuleRecipesViewModel> Modules { get; set; }
    }

    public class ModuleRecipesViewModel
    {
        public ModuleEntry Module { get; set; }

        public IEnumerable<Recipe> Recipes { get; set; }
    }
}