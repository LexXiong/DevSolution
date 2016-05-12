using System;
using System.IO;

namespace Orchard
{
    public class Program
    {
        private const int ConsoleInputBufferSize = 8192;

        public static int Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(ConsoleInputBufferSize)));
            return (int)new OrchardHost(Console.In, Console.Out, args).Run();
        }
    }
}