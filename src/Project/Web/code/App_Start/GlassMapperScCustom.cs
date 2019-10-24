#region GlassMapperScCustom generated code
using Glass.Mapper.Configuration;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Pipelines.ObjectConstruction;
using Glass.Mapper.Pipelines.ObjectConstruction.Tasks.DepthCheck;
using Glass.Mapper.Sc.IoC;
using Glass.Mapper.Sc.Pipelines.ObjectConstruction;
using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace Books.Project.Web.App_Start
{
    public static class GlassMapperScCustom
    {
        public static IDependencyResolver CreateResolver()
        {
            Glass.Mapper.Sc.Config config = new Glass.Mapper.Sc.Config();
            DependencyResolver dependencyResolver = new DependencyResolver(config);

            // Add any changes to the standard resolver here
            // Added this to disable Version Count since VersionCountDisabler has been removed in Glass v5.
            AbstractConfigFactory<AbstractObjectConstructionTask> factory = dependencyResolver.ObjectConstructionFactory as AbstractConfigFactory<AbstractObjectConstructionTask>;
            factory.Remove<ItemVersionCountByRevisionTask>();
            factory.Remove<ModelDepthCheck>();
            return dependencyResolver;
        }

        public static IConfigurationLoader[] GlassLoaders()
        {

            /* USE THIS AREA TO ADD FLUENT CONFIGURATION LOADERS
             * 
             * If you are using Attribute Configuration or automapping/on-demand mapping you don't need to do anything!
             * 
             */

            return new IConfigurationLoader[] { };
        }
        public static void PostLoad()
        {
            //Remove the comments to activate CodeFist
            /* CODE FIRST START
            var dbs = Sitecore.Configuration.Factory.GetDatabases();
            foreach (var db in dbs)
            {
                var provider = db.GetDataProviders().FirstOrDefault(x => x is GlassDataProvider) as GlassDataProvider;
                if (provider != null)
                {
                    using (new SecurityDisabler())
                    {
                        provider.Initialise(db);
                    }
                }
            }
             * CODE FIRST END
             */
        }
        public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
            // Add maps here
            // mapsConfigFactory.Add(() => new SeoMap());
        }
    }
}
#endregion