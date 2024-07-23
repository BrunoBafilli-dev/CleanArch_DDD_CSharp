using Domain.Request.Repositories.Request;
using Domain.Request.Services;
using Domain.Request.Services.Request.Interfaces;
using Infrastructure.Request.Repositories.Request;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI.DIConfigurations.InjectionConfigFacadeServices
{
    public class DomainInjectionConfigService
    {
        public static void Domain(IServiceCollection services)
        {
            services.AddScoped<IRequestDomainService, RequestDomainService>();
            services.AddScoped<IRequestRepository, RequestRepository>();
        }
    }
}
