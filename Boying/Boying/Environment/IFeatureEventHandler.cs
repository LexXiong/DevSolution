using Boying.Environment.Extensions.Models;
using Boying.Events;

namespace Boying.Environment
{
    public interface IFeatureEventHandler : IEventHandler
    {
        void Installing(Feature feature);

        void Installed(Feature feature);

        void Enabling(Feature feature);

        void Enabled(Feature feature);

        void Disabling(Feature feature);

        void Disabled(Feature feature);

        void Uninstalling(Feature feature);

        void Uninstalled(Feature feature);
    }
}