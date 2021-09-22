using FlightComputer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using FlightComputer.lib.Control;
using FlightComputer.lib.Network;
using FlightComputer.lib.Serial;
using System.Threading;

namespace FlightComputer
{
    class Program
    {
        public static Task Main(string[] args)
        {
            // Configure Services
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            IServiceProvider provider = serviceCollection.BuildServiceProvider();


            Console.WriteLine("Initiating Flight Computer...");
            var CommService = provider.GetService<CommunitcationService>();
            var Serial = provider.GetService<SerialComms>();
            var Network = provider.GetService<NetworkModel>();
            var Control = provider.GetService<Control>();

            CommService.Start();

            while(true)
            {
                Console.WriteLine($"Flight Computer Active at {DateTime.UtcNow}");
                Thread.Sleep(1500);
            }
            throw new ApplicationException();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // IServiceCollection
            services.AddLogging(configure => configure.AddConsole())
                .AddSingleton<CommunitcationService>()
                .AddSingleton<SerialComms>()
                .AddSingleton<NetworkModel>()
                .AddSingleton<Control>();
        }

   
    }
}
