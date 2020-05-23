using OrchardCore.ResourceManagement;

namespace Resume
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("Resume")
                .SetDependencies("bootstrap") //, jQuery.easing
                .SetUrl("~/Resume/js/scripts.min.js", "~/Resume/js/scripts.js")
                .SetVersion("6.0.0");

            manifest
                .DefineStyle("Resume")
                .SetUrl("~/Resume/css/styles.min.css", "~/Resume/css/styles.css")
                .SetVersion("6.0.0");
        }
    }
}
