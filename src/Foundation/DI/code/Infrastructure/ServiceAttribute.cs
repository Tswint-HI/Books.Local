using System;

namespace Books.Foundation.DI.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        public Lifetime Lifetime { get; set; } = Lifetime.Singleton;

        public Type ServiceType { get; set; }

        public ServiceAttribute()
        {
        }

        public ServiceAttribute(Type serviceType) => ServiceType = serviceType;
    }
}