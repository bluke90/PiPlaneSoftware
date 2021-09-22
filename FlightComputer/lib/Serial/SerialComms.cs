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

        public SerialComms(string portName)
        {
            _serial = new SerialPort();
            _serial.PortName = portName;
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
        
        private void InitSerialPort() { _serial.Open(); }
    }
}
