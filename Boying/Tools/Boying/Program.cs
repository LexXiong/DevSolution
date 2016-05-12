using System;
using System.IO;

namespace Boying
{
    public class Program
    {
        private const int ConsoleInputBufferSize = 8192;

        public static int Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(ConsoleInputBufferSize)));
            return (int)new BoyingHost(Console.In, Console.Out, args).Run();
        }
    }
}