using Application.Services.Request.Interfaces;
using Infrastructure.IOC.ContainerDI;

namespace ClassLibrary1
{
    public class Class1
    {
        _requestApplicationService = DIConfiguration.GetService<IRequestApplicationService>();
    }
}
