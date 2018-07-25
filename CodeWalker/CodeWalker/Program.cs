using CodeWalker.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var help = @"usagi CodeWalker [VB Project] [Output file name]";

            Console.WriteLine("CodeWalker - VB Code Analyzer");
            Console.WriteLine();

            if (args.Length != 2)
            {
                Console.WriteLine(help);
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine(help);
                Console.WriteLine("VB project file not found.");
                return;
            }

            Saru.Analyze(args[0], args[1]);
        }
    }
}
