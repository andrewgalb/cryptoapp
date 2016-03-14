using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) { Console.WriteLine("No parameters"); return; }

            if (args[0] == "help") { printHelp(); }
            //Console.WriteLine(args[0]);

        }

        static void printHelp()
        {
            string helpText = "CryptoApp is used to encrypt your text files.\n";
            helpText += "Format: Cryptapp -(parameter) (name of source file) (name of desination file)";
            helpText += "Parameters:\n";
            helpText += "-help\tThis help text";
            helpText += "";
            Console.WriteLine(helpText);
        }
    }
}
