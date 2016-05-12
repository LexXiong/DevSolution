using Boying.UI.Resources;

namespace Boying.Modules
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            builder.Add().DefineStyle("ModulesAdmin").SetUrl("Boying-modules-admin.css");
        }
    }
}