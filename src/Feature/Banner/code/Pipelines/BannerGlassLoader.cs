using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.Banner.Pipelines
{
    public class BannerGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args) => args.Loaders.Add(new SitecoreAttributeConfigurationLoader("Books.Feature.Banner"));
    }
}