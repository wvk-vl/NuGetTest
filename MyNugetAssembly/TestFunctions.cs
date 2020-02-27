using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistalink.NuGetTest
{
    /// <summary>
    /// Some test functions for our NuGet Package
    /// </summary>
    public static class TestFunctions
    {
        /// <summary>
        /// Returns some text
        /// </summary>
        public static string SomeText => "I Like Nuggets";

        /// <summary>
        /// Prints the <see cref="SomeText"/> property
        /// </summary>
        public static void PrintSomeText() => Console.WriteLine(SomeText);
    }
}
