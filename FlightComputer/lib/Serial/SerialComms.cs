using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightComputer.lib.Serial
{
    public class SerialComms
    {
        private readonly SerialPort _serial;

        public SerialComms()
        {
            _serial = new SerialPort();
            _serial.BaudRate = 9600;
        }

        public void Send(string toSend) {
            Console.WriteLine("==Testing==    Initiate Serial Port...");
            //InitSerialPort();
            Console.WriteLine($"==Testing==    Write \'{toSend}\' to serial");
            //_serial.Write(toSend);
            Console.WriteLine("==Testing==    Close Serial Port...");
            //_serial.Close();
        }
        
        private void InitSerialPort() {
            if (_serial.PortName == null || _serial.PortName == string.Empty)
                throw new Exception("No Port Name was provided Serial Connectivity...");

            _serial.Open();
        }

        public string GetPortName()
        {
            return _serial.PortName;
        }

        public void SetPortName(string portName)
        {
            _serial.PortName = portName;
        }
    }
}
