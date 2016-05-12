using Boying.UI.Resources;

namespace Boying.Themes {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineStyle("ThemesAdmin").SetUrl("Boying-themes-admin.css");
        }
    }
}
