using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Pipelines.GetGlassLoaders;

namespace Books.Feature.Carousel.Pipelines
{
    public class CarouselGlassLoader : GetGlassLoadersProcessor
    {
        public override void Process(GetGlassLoadersPipelineArgs args) => args.Loaders.Add(new SitecoreAttributeConfigurationLoader("Books.Feature.Carousel"));
    }
}