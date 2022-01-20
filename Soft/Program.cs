using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service.Common;
using System;
using System.Threading.Tasks;

namespace TelegramBotTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            host.Start();


        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices(
                (_, services) =>
                    services.AddTransient<IService>()
                );
    }
}
