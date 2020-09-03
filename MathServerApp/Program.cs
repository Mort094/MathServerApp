using System;

namespace MathServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServer worker = new MathServer();
            worker.Start();

            Console.ReadLine();
        }
    }
}
