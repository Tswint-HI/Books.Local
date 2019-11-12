using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.BookCard
{
    public class BookCardGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args)
        {
            SitecoreAttributeConfigurationLoader loader = new SitecoreAttributeConfigurationLoader("Books.Feature.Carousel");
            args.Loaders.Add(loader);
        }
    }
}