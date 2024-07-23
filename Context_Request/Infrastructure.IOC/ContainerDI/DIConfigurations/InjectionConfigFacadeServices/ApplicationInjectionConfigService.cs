using Application.DTOs;
using Application.Request.Events.EventBus;
using Application.Request.Events.Request.Handlers.CreatedRequestDomainEventHandlers;
using Application.Request.Events.Request.Handlers.CreatedRequestEventHandlers;
using Application.Request.Events.Request.Saga;
using Application.Request.Services.Request;
using Application.Services.Request.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI.DIConfigurations.InjectionConfigFacadeServices
{
    public class ApplicationInjectionConfigService
    {
        public static void Application(IServiceCollection services)
        {
            services.AddScoped<RequestApplicationServiceDependencies>();
            services.AddScoped<IRequestApplicationService, RequestApplicationService>();
            services.AddScoped<IUpdateReduceStockSaga, UpdateReduceStockSaga>();
            services.AddScoped<IEventBus, EventBus>();

            //Events Mediatr
            services.AddMediatR(cfg =>
            {
                //É necessário somente 1 instancia e o mediatr localiza os outros, mas por organizacao, coloquei todos.
                cfg.RegisterServicesFromAssembly(typeof(CreatedRequestEmailNotificationEventHandler).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(NotificationStockContextUpdateStockItemEventHandler).Assembly);
            });

            //Automapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

    }
}
