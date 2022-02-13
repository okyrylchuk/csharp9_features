using System;

namespace LambdaDiscardParameters
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1415747088592297986
    class Program
    {
        class Button
        {
            public event EventHandler Click;
        }

        static void Main()
        {
            void PrintHelloWorld()
            {
                Console.WriteLine("Hello World!");
            }

            Button button = new();
            button.Click += (_, _) => PrintHelloWorld();
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*static void Main()
        {
            void PrintHelloWorld()
            {
                Console.WriteLine("Hello World!");
            }


            var button = new Button();
            button.Click += (s, e) => PrintHelloWorld();
        }*/
        #endregion
    }
}
