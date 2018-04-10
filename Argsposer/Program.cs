using System;
using System.Threading;

namespace Argsposer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argsposer v.1 - The Only Version You Need");
            Console.WriteLine("─────────────────────────────────────────");
            Console.WriteLine("Command Line Arguments:");
            if (args.Length == 0)
            {
                Console.WriteLine(" [none]");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(" " + i + ": '" + args[i] + "'");
                }
            }
            Console.WriteLine();
            if (Console.IsInputRedirected)
            {
                Console.WriteLine("Piped Data:");
                using (var input = Console.OpenStandardInput())
                {
                    using (var output = Console.OpenStandardOutput())
                    {
                        int bytes;
                        byte[] data = new byte[2048];
                        while ((bytes = input.Read(data, 0, data.Length)) > 0)
                        {
                            output.Write(data, 0, bytes);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No piped data.");
            }
            Console.WriteLine();
            Console.Write("Ctrl-C to exit...");
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
