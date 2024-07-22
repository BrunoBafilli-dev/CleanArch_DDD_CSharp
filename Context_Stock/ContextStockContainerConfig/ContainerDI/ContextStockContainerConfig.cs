using Application.Stock.Events.Item.Handlers.UpdatedItemReducedStockEventHandlers;
using Domain.Stock.Repositories;
using Infrastructure.Stock.Database.EntityFramework;
using Infrastructure.Stock.Repository;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.IOC.Request.ContainerDI
{
    public class ContextStockContainerConfig
    {
        public static void AddContextStockServices(IServiceCollection services) // Tornar público
        {
            services.AddScoped<ItemDataContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            services.AddMediatR(cfg =>
             {
                 cfg.RegisterServicesFromAssembly(typeof(UpdatedItemReducedStockEventHandler).Assembly);
             });
        }
    }
}
