using Microsoft.Practices.ServiceLocation;

namespace Spekulatius 
{
    public interface IDependencyInjectionConfiguration 
    {
        IServiceLocator GetServiceLocator();

        void Register<T>(T implementation);
    }
}