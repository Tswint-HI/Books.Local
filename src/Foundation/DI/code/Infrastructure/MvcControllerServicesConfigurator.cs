﻿using Books.Foundation.Orm.Repo;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using Glass.Mapper.Sc.Web.WebForms;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Data;
using Sitecore.DependencyInjection;
using System;

namespace Books.Foundation.DI.Infrastructure
{
    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Foundation.*");

            serviceCollection.AddSingleton<Func<Database, ISitecoreService>>(_ => CreateSitecoreService);

            // For injecting into Controllers and Web Forms
            serviceCollection.AddScoped(_ => CreateSitecoreContextService());
            serviceCollection.AddScoped(_ => CreateRequestContext());
            serviceCollection.AddScoped(_ => CreateGlassHtml());
            serviceCollection.AddScoped(_ => CreateMvcContext());
            serviceCollection.AddScoped(_ => CreateWebFormsContext());
            serviceCollection.AddScoped(_ => CreateSitecoreRepository(CreateRequestContext()));

            // For injecting into Configuration Factory types like pipeline processors
            serviceCollection.AddSingleton<Func<ISitecoreService>>(_ => Get<ISitecoreService>);
            serviceCollection.AddSingleton<Func<IRequestContext>>(_ => Get<IRequestContext>);
            serviceCollection.AddSingleton<Func<IGlassHtml>>(_ => Get<IGlassHtml>);
            serviceCollection.AddSingleton<Func<IMvcContext>>(_ => Get<IMvcContext>);
            serviceCollection.AddSingleton<Func<IWebFormsContext>>(_ => Get<IWebFormsContext>);
            //serviceCollection.AddSingleton<Func<SitecoreRepository>>(_ => Get<SitecoreRepository>);
        }

        private static ISitecoreService CreateSitecoreService(Database database)
        {
            return new SitecoreService(database);
        }

        private static ISitecoreService CreateSitecoreContextService()
        {
            var sitecoreServiceThunk = Get<Func<Database, ISitecoreService>>();
            return sitecoreServiceThunk(Sitecore.Context.ContentDatabase ?? Sitecore.Context.Database);
        }

        private static T Get<T>()
        {
            return ServiceLocator.ServiceProvider.GetService<T>();
        }

        private static IRequestContext CreateRequestContext()
        {
            return new RequestContext(Get<ISitecoreService>());
        }

        private static IGlassHtml CreateGlassHtml()
        {
            return new GlassHtml(Get<ISitecoreService>());
        }

        private static IMvcContext CreateMvcContext()
        {
            return new MvcContext(Get<ISitecoreService>(), Get<IGlassHtml>());
        }

        private static IWebFormsContext CreateWebFormsContext()
        {
            return new WebFormsContext(Get<ISitecoreService>(), Get<IGlassHtml>());
        }

        private static SitecoreRepository CreateSitecoreRepository(IRequestContext requestContext)
        {
            return new SitecoreRepository(CreateRequestContext());
        }
    }
}