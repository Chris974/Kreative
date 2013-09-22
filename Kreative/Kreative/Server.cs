using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Kreative
{
    public class Server
    {
        public TcpListener listener;
        public Server s;
        private Properties p { get; set; }
        public bool isRunning;

        private Logger logger { get; set; }

        public Server()
        {

        }

        public void StartServer()
        {
            try
            {
                if (s.isRunning != true)
                {
                    Console.Title = "KreativeSMP: V1.0.0";
                    Logger.Log("[Kreative]: Starting server...");
                    listener = new TcpListener(IPAddress.Any, p.port);
                    listener.Start();
                    while (true)
                    {
                        Console.ReadLine();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
