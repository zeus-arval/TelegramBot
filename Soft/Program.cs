using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service.Common;

namespace TelegramBotTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();



        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IService>();    
        }
    }
}
