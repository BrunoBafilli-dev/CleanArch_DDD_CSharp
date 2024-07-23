using Infrastructure.IOC.Request.ContainerDI.DIConfigurations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI
{
    public class ContextRequestContainerConfig
    {
        public static void AddContextRequestServices(IServiceCollection services) 
        {
            InjectionConfigFacade.Infrastructure(services);
            InjectionConfigFacade.Application(services);
            InjectionConfigFacade.Domain(services);
        }
    }
}
