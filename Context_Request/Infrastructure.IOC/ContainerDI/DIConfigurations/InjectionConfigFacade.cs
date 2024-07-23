using Infrastructure.IOC.Request.ContainerDI.DIConfigurations.InjectionConfigFacadeServices;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI.DIConfigurations
{
    public class InjectionConfigFacade
    {
        public static void Application(IServiceCollection _services) => ApplicationInjectionConfigService.Application(_services);

        public static void Domain(IServiceCollection _services) => DomainInjectionConfigService.Domain(_services);

        public static void Infrastructure(IServiceCollection _services) => InfrastructureInjectionConfigService.Infrastructure(_services);
    }
}
