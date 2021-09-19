using FlightComputer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightComputer.lib.Network
{
    public class NetworkModel
    {
        public Socket Socket { get; set; }
        private IPEndPoint _localEndPoint { get; set; }
        private IPAddress _ipAddr { get; set; }
        private IPHostEntry _ipHost { get; set; }
        public Queue<String> DataQueue { get; set; }
        private Socket ClientSocket { get; set; }

        public void InitSocket()
        {
            _ipHost = Dns.GetHostEntry(Dns.GetHostName());
            _ipAddr = _ipHost.AddressList[0];
            _localEndPoint = new IPEndPoint(_ipAddr, 1005);
            Socket = new Socket(_ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Listen()
        {
            try
            {
                Socket.Bind(_localEndPoint);

                Socket.Listen(4);

                while (true)
                {

                    Console.WriteLine("Waiting connection ... ");
                    ClientSocket = Socket.Accept();

                    // Data buffer
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {
                        int numByte = ClientSocket.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, numByte);
                        if (data.IndexOf("<EOF>") > -1)
                            break;
                    }

                    DataQueue.Enqueue(data);

                    Console.WriteLine("Text received -> {0} ", data);

                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close();
                }
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendString(string data)
        {
            byte[] message = Encoding.ASCII.GetBytes(data);

            ClientSocket.Send(message);
        }

    }

}
