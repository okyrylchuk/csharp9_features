namespace ExtendedPartialMethods
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1416839495132065793
    class Program
    {
        partial class Example
        {
            // Other than void return type is allowed
            public partial int A();
            // Access modifiers are allowed
            public partial void B();
            // Out params are allowed
            public partial void C(out int param);
        }

        partial class Example
        {
            public partial int A() => 0;
            public partial void B() { }
            public partial void C(out int param)
            {
                param = 0;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
