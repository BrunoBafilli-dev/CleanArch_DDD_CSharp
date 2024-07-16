using Application.DTOs;
using Application.Events.EventBus;
using Application.Events.Request.Handlers.CreatePruductEventsGroup;
using Application.Events.Tools;
using Application.Services.Request;
using Application.Services.Request.Interfaces;
using Domain.Repositories.Request;
using Domain.Services;
using Domain.Services.Request.Interfaces;
using Domain.UnitOfWork;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Request;
using Infrastructure.Tools;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.ContainerDI
{
    public class DIConfiguration
    {
        private static ServiceProvider _serviceProvider;

        static DIConfiguration()
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
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

            services.AddMediatR(cfg =>
             {
                 //É necessário somente 1 instancia e o mediatr localiza os outros, mas por organizacao, coloquei todos.
                 cfg.RegisterServicesFromAssembly(typeof(CreatedRequestEmailNotificationEventHandle).Assembly);
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
