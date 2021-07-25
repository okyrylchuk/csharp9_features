using System;

namespace RecordsAndInheritance
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1418978770220896257
    class Program
    {
        record Person
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }

        record Employee : Person
        {
            public string Position { get; init; }
        }

        static void Main()
        {
            Person person = new Employee
            {
                FirstName = "Oleg",
                LastName = "Kyrylchuk",
                Position = ".NET Developer"
            };

            // Hidden virtual method copies the whole record (as Employee)
            Person newPerson = person with { LastName = "Bond" };

            Employee employee = newPerson as Employee;
            Console.WriteLine(employee.FirstName); // Oleg
            Console.WriteLine(employee.LastName);  // Bond
            Console.WriteLine(employee.Position);  // .NET Developer
        }
    }
}
