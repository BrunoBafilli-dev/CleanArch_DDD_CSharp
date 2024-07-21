using Application.DTOs;
using Application.Request.Events.EventBus;
using Application.Request.Events.Request.Handlers.CreatePruductEvents;
using Application.Request.Events.Tools;
using Application.Request.Services.Request;
using Application.Services.Request.Interfaces;
using Domain.Request.Repositories.Request;
using Domain.Request.Services;
using Domain.Request.Services.Request.Interfaces;
using Domain.Request.UnitOfWork;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request;
using Infrastructure.Request.Tools;
using Infrastructure.Request.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.Request.ContainerDI
{
    public class DiConfiguration
    {
        private static ServiceProvider _serviceProvider;

        static DiConfiguration()
        {
            var services = new ServiceCollection();
            RegisterServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<DataContext>();
            services.AddScoped<RequestApplicationServiceDependencies>();
            services.AddScoped<IRequestApplicationService, RequestApplicationService>();
            services.AddScoped<IRequestDomainService, RequestDomainService>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IEventBus, EventBus>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMediatR(cfg =>
             {
                 //É necessário somente 1 instancia e o mediatr localiza os outros, mas por organizacao, coloquei todos.
                 cfg.RegisterServicesFromAssembly(typeof(CreatedRequestEmailNotificationEventHandle).Assembly);
                 cfg.RegisterServicesFromAssembly(typeof(NotificationStockContextUpdateStockItemEventHandler).Assembly);
             });

            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        //Metodo de extensao.
        //public static IServiceCollection AddInfraStructure(
        //    this IServiceCollection services,
        //    IConfiguration configuration)
        //{

        //    RegisterServices(services);

        //    services.AddAutoMapper(typeof(AutoMapperProfile));

        //    //var sqlConnection = configuration.GetConnectionString("DefaultConnection");

        //    //services.AddDbContext<DataContext>(options =>
        //    //options.UseSqlServer(sqlConnection));

        //    return services;
        //}
    }
}
