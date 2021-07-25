using System;

namespace UnconstrainedTypeParameters
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1416125980368936967
    class Program
    {
        #nullable enable
        class Example
        {
            // no overloads
            // handle both reference and value types
            public void DoSomething<T>(T? param)
            { }
        }

        static void Main()
        {
            var example = new Example();

            // reference type, not null
            example.DoSomething(new object());
            // reference type, null
            example.DoSomething<object>(null);
            // value type
            example.DoSomething(DateTime.Today);
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*#nullable enable
        class Example
        {
            // for value types
            public void DoSomething<T>(T? param)
                where T : struct
            { }

            // overload for reference types
            public void DoSomething<T>(T? param)
                where T : class
            { }
        }

        static void Main()
        {
            var example = new Example();

            // reference type, not null
            example.DoSomething(new object());
            // reference type, null
            example.DoSomething<object>(null);
            // value type
            example.DoSomething<DateTime>(DateTime.Today);
        }*/
        #endregion
    }
}
