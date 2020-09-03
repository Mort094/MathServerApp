using System;
using System.IO;
using System.Net.Sockets;

namespace MathClientApp
{
    internal class Mathclient
    {
        public void Start()
        {
            TcpClient socket = new TcpClient("localhost", 3001);

            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

           // String str1 = "add 3 4";
           String str1 = Console.ReadLine();
            sw.WriteLine(str1);
            sw.Flush();

            String strRetur = sr.ReadLine();
            Console.WriteLine($"{strRetur}");
            socket.Close();
        }
    }
}