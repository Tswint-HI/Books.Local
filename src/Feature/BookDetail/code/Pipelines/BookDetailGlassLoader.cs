using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.BookDetail.Pipelines
{
    public class BookDetailGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args)
        {
            SitecoreAttributeConfigurationLoader loader = new SitecoreAttributeConfigurationLoader("Books.Feature.BookDetail");
            args.Loaders.Add(loader);
        }
    }
}