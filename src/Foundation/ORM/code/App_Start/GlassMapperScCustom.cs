#region GlassMapperScCustom generated code

using Glass.Mapper.Configuration;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Sc.IoC;

using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace Books.Foundation.Orm.App_Start
{
    public static class GlassMapperScCustom
    {
        public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
            // Add maps here
            // mapsConfigFactory.Add(() => new SeoMap());
        }

        public static IDependencyResolver CreateResolver()
        {
            var config = new Glass.Mapper.Sc.Config();

            var dependencyResolver = new DependencyResolver(config);
            // add any changes to the standard resolver here
            return dependencyResolver;
        }

        /* USE THIS AREA TO ADD FLUENT CONFIGURATION LOADERS
             *
             * If you are using Attribute Configuration or automapping/on-demand mapping you don't need to do anything!
             *
             */

        public static IConfigurationLoader[] GlassLoaders() => new IConfigurationLoader[] { };

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
    }
}

#endregion GlassMapperScCustom generated code