using OrchardCore.ResourceManagement;

namespace TheSampleStoreTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("TheSampleStoreTheme")
                .SetUrl("~/TheSampleStoreTheme/css/TheSampleStoreTheme.min.css", "~/TheSampleStoreTheme/css/TheSampleStoreTheme.css")
                .SetVersion("1.0.0");

            manifest.DefineScript("TheSampleStoreTheme")
                .SetUrl("~/TheSampleStoreTheme/js/TheSampleStoreTheme.min.js", "~/TheSampleStoreTheme/js/TheSampleStoreTheme.js")
                .SetVersion("1.0.0");
        }
    }
}