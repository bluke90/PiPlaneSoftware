using FlightComputer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using FlightComputer.lib.Control;
using FlightComputer.lib.Network;
using FlightComputer.lib.Serial;

namespace FlightComputer
{
    class Program
    {
        public static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            var services = host.Services;
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            var lfactory = provider.GetRequiredService<LoggerFactory>();
            var logging = lfactory.CreateLogger("Program");
            logging.LogInformation("Starting Flight Computer... Please Wait...");
            Console.WriteLine("Initiating Flight Computer...");
            var Serial = new SerialComms("COM3"); // Communicate with Flight Controller
            var Network = new NetworkModel(); // Communicate with Base
            var Control = new Control(Network, Serial);
            Control.StartControlThread();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                }).ConfigureServices(services => 
                { 
                    services.AddLogging();
                });
            return host;
        }

   
    }
}
