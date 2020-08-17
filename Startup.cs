using starter_module_mvc.Services;
using starter_module_mvc.Services.Interfaces;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace starter_module_mvc
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMyService, MyService>();
        }
    }
}