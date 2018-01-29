using Microsoft.Practices.ServiceLocation;

namespace Wiki.js_desktop
{
    public interface IDependencyInjectionConfiguration
    {
        IServiceLocator GetServiceLocator();

        void Register<T>(T implementation);
    }
}