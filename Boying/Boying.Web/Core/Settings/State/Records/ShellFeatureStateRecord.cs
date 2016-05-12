using Boying.Environment.State.Models;

namespace Boying.Core.Settings.State.Records
{
    public class ShellFeatureStateRecord
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ShellFeatureState.State InstallState { get; set; }

        public virtual ShellFeatureState.State EnableState { get; set; }
    }
}