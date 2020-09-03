using System;

namespace MathClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathclient worker = new Mathclient();
            worker.Start();

            Console.ReadLine();
        }
    }
}
