using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MathServerApp
{
    internal class MathServer
    {
        internal void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 3001);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            while (true)
            {
                String str = sr.ReadLine();
                String[] vs = str.Split(" ");
                int x = Int32.Parse(vs[1]);
                int y = Int32.Parse(vs[2]);

                int resultat = x + y;
                String strRetur = "Resultat = ";
                sw.WriteLine(strRetur + resultat);
                sw.Flush();
            }
        }
    }
}