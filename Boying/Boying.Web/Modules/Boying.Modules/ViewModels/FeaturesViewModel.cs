using System;
using System.Collections.Generic;
using Boying.Environment.Extensions.Models;
using Boying.Modules.Models;

namespace Boying.Modules.ViewModels
{
    public class FeaturesViewModel
    {
        public IEnumerable<ModuleFeature> Features { get; set; }

        public FeaturesBulkAction BulkAction { get; set; }

        public Func<ExtensionDescriptor, bool> IsAllowed { get; set; }
    }

    public enum FeaturesBulkAction
    {
        None,
        Enable,
        Disable,
        Update,
        Toggle
    }
}