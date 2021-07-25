namespace DefaultConstraint
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1416484181606010885
    class Program
    {
        #nullable enable
        class Base
        {
            // no overloads
            // handle both reference and value types
            public virtual void DoSomething<T>(T? param) { }
        }

        class Overridden : Base
        {
            // override with default constraint
            // handle both reference and value types
            public override void DoSomething<T>(T? param)
                where T : default
            { }
        }

        static void Main()
        {
            Base @base = new();
            @base.DoSomething(1); // value type
            @base.DoSomething(new object()); // ref type, not null
            @base.DoSomething<object>(null); // ref type, null

            Overridden overriden = new();
            overriden.DoSomething(1); // value type
            overriden.DoSomething(new object()); // ref type, not null
            overriden.DoSomething<object>(null); // ref type, null
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*#nullable enable
        class Base
        {
            // for value types
            public virtual void DoSomething<T>(T? param)
                where T : struct
            { }

            // overload for reference type
            public virtual void DoSomething<T>(T? param)
                where T : class
            { }
        }

        class Overridden : Base
        {
            // override for value types
            public override void DoSomething<T>(T? param)
                where T : struct
            { }

            // override overload for reference types
            public override void DoSomething<T>(T? param)
                where T : class
            { }
        }

        static void Main()
        {
            var @base = new Base();
            @base.DoSomething<int>(1); // value type
            @base.DoSomething(new object()); // ref type, not null
            @base.DoSomething<object>(null); // ref type, null

            Overridden overridden = new Overridden();
            overridden.DoSomething<int>(1); // value type
            overridden.DoSomething(new object()); // ref type, not null
            overridden.DoSomething<object>(null); // ref type, null
        }*/
        #endregion
    }
}
