using OrchardCore.ResourceManagement;

namespace TheResumeTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("Resume")
                .SetDependencies("bootstrap") //, jQuery.easing
                .SetUrl("~/TheResumeTheme/js/scripts.min.js", "~/TheResumeTheme/js/scripts.js")
                .SetVersion("6.0.0");

            manifest
                .DefineStyle("Resume")
                .SetUrl("~/TheResumeTheme/css/styles.min.css", "~/TheResumeTheme/css/styles.css")
                .SetVersion("6.0.0");
        }
    }
}
