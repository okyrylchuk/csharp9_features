using System;
using System.Collections.Generic;

namespace ExtensionGetEnumerator
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1417205582579306499
    public static class Extensions
    {
        public static IEnumerator<T> GetEnumerator<T>
            (this IEnumerator<T> enumerator) => enumerator;
    }


    class Program
    {
        static void Main()
        {
            var list = new List<int> { 1, 2, 3 };
            IEnumerator<int> enumerator = list.GetEnumerator();
            foreach (int i in enumerator)
            {
                Console.WriteLine(i);
            }
            // Output:
            // 1
            // 2
            // 3
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*static void Main()
        {
            var list = new List<int> { 1, 2, 3 };
            IEnumerator<int> enumerator = list.GetEnumerator();
            foreach (int i in enumerator)
            {
                Console.WriteLine(i);
            }
            // Compilation error without extension:
            // Error CS1579: foreach statement cannot operate on variables of type
            // 'IEnumerator<int>' because 'IEnumerator<int>' does not contain a public
            // instance definition for 'GetEnumerator'.

            // Compilation error with extension:
            // Feature 'extension GetEnumerator()' is not available in C# 8.0.
            // Please use language version C# 9.0 or greater.
        }*/
        #endregion
    }
}
