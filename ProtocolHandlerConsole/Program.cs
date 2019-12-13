using System;
using System.Linq;

namespace ProtocolHandlerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Protocol Handler Console!");
            Console.WriteLine(string.Empty);

            Console.WriteLine($"Full command line: {Environment.CommandLine}");
            Console.WriteLine(string.Empty);

            Console.WriteLine("Full command line args:");

            args.ToList().ForEach(arg => Console.WriteLine(arg));

            Console.ReadLine();
        }
    }
}
