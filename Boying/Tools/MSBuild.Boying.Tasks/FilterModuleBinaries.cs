using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MSBuild.Boying.Tasks
{
    public class FilterModuleBinaries : Task
    {
        public ITaskItem[] ModulesBinaries { get; set; }

        public ITaskItem[] BoyingWebBinaries { get; set; }

        [Output]
        public ITaskItem[] ExcludedBinaries { get; set; }

        public override bool Execute()
        {
            if (ModulesBinaries == null || BoyingWebBinaries == null)
                return true;

            var BoyingWebAssemblies = new HashSet<string>(
                BoyingWebBinaries.Select(item => Path.GetFileName(item.ItemSpec)),
                StringComparer.InvariantCultureIgnoreCase);

            ExcludedBinaries = ModulesBinaries
                .Where(item => BoyingWebAssemblies.Contains(Path.GetFileName(item.ItemSpec)))
                .Select(item => new TaskItem(item))
                .ToArray();

            return true;
        }
    }
}