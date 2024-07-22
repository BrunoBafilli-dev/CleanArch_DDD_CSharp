using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SharedKernel.Stock.Events.EventBus;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.SharedKernel.ContainerDI
{
    public class ContextSharedKernelContainerConfig
    {
        public static void AddContextSharedKernelServices(IServiceCollection services)
        {
            services.AddScoped<SKIEventBus, SKEventBus>();
        }
    }
}
