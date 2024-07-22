using Infrastructure.IOC.Request.ContainerDI;
using Infrastructure.IOC.SharedKernel.ContainerDI;
using Microsoft.Extensions.DependencyInjection;

namespace ContainerDI.StartCore
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
            ContextSharedKernelContainerConfig.AddContextSharedKernelServices(services);
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
