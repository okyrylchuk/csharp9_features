using System;

namespace AttributesOnLocalFunctions
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1415385617018490881
    class Program
    {
        static void Main()
        {
            [Obsolete("Attribute on local function")]
            void LocalFunction()
            {
                Console.WriteLine("Hello World!");
            }

            LocalFunction();
        }
    }
}
