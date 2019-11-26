using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.BookCard.Pipelines
{
    public class BookCardGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args)
        {
            SitecoreAttributeConfigurationLoader loader = new SitecoreAttributeConfigurationLoader("Books.Feature.BookCard");
            args.Loaders.Add(loader);
        }
    }
}