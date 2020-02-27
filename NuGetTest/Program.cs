using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistalink.NuGetTest;

namespace NuGetTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Printing the value: '{TestFunctions.SomeText}'");

            Console.WriteLine("Now calling the function...");
            TestFunctions.PrintSomeText();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");

            Console.ReadLine();

        }
    }
}
