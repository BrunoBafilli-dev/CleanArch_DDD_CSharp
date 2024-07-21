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
using Infrastructure.IOC.Request.ContainerDI;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request;
using Infrastructure.Request.Tools;
using Infrastructure.Request.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using Domain.SharedKernel.Stock.Events.EventBus;

namespace ContainerDI.Core
{
    public class DIConfiguration
    {
        private static ServiceProvider _serviceProvider;

        static DIConfiguration()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            // Adicionando serviços dos contextos
            ContextRequestContainerConfig.AddContextRequestServices(services);
            ContextStockContainerConfig.AddContextStockServices(services);
            services.AddScoped<SKIEventBus, SKEventBus>();
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        // Método de extensão.
        // public static IServiceCollection AddInfraStructure(
        //     this IServiceCollection services,
        //     IConfiguration configuration)
        // {
        //     RegisterServices(services);
        //     services.AddAutoMapper(typeof(AutoMapperProfile));
        //     // var sqlConnection = configuration.GetConnectionString("DefaultConnection");
        //     // services.AddDbContext<DataContext>(options =>
        //     // options.UseSqlServer(sqlConnection));
        //     return services;
        // }
    }
}
