using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.Hero
{
    public class HeroGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args)
        {
            SitecoreAttributeConfigurationLoader loader = new SitecoreAttributeConfigurationLoader("Books.Feature.Hero");
            args.Loaders.Add(loader);
        }
    }
}