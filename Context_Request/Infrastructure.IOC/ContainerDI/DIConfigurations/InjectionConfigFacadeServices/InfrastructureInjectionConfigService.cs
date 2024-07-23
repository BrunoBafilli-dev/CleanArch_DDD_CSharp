using Application.Request.Tools.Notifiers;
using Domain.Request.Repositories;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories;
using Infrastructure.Request.Tools.Notifiers;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI.DIConfigurations.InjectionConfigFacadeServices
{
    public class InfrastructureInjectionConfigService
    {
        public static void Infrastructure(IServiceCollection services)
        {
            services.AddScoped<RequestDataContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmailSender, EmailSender>();
        }
    }
}
