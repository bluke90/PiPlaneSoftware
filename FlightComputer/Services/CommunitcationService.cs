using FlightComputer.lib.Network;
using FlightComputer.lib.Serial;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightComputer.Services
{
    public class CommunitcationService // Background Service
    {

        private readonly SerialComms _serial;
        private readonly NetworkModel _network;
        private readonly ILogger<CommunitcationService> _logger;

        public CommunitcationService(SerialComms serial, NetworkModel network, ILogger<CommunitcationService> logger)
        {
            _serial = serial;
            _network = network;
            _logger = logger;
        }

        public void Start()
        {
            Thread thread = new Thread(ExecuteAsync);
            thread.Start();
        }

        private void ExecuteAsync()
        {
            while (true)
            {
                try
                {
                    _logger.LogInformation("Sucessfully Initiated Execution of CommunicationService Thread");

                    Thread.Sleep(100000);
                } catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
            }
        }
    }
}
