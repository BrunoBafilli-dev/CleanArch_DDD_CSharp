using Application.Stock.Events.Item.Handlers.UpdatedItemReducedStockEventHandlers;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.IOC.Request.ContainerDI
{
    public class ContextStockContainerConfig
    {
        public static void AddContextStockServices(IServiceCollection services) // Tornar público
        {
            services.AddMediatR(cfg =>
             {
                 cfg.RegisterServicesFromAssembly(typeof(UpdatedItemReducedStockEventHandler).Assembly);
             });
        }
    }
}
