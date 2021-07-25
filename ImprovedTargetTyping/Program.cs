namespace ImprovedTargetTyping
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1412139149583437833
    // And from tweet https://twitter.com/okyrylchuk/status/1412502863356469253
    // To run C#8 version change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
    class Program
    {
        class Person { }

        class Student : Person { }

        class Customer : Person { }

        static void Main(string[] args)
        {
            // Target-typed new expression
            Student student = new ();
            // Target-typed new expression
            Customer customer = new ();
            bool isStudent = true;

            // Target-typed conditional ?:
            Person person = isStudent ? student : customer;
        }
    }
}
