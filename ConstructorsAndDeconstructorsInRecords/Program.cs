using System;

namespace ConstructorsAndDeconstructorsInRecords
{
    class Program
    {
        // Positional record
        record Person(string FirstName, string LastName);

        /* Usual record
        record Person
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }

            // Constructor
            public Person(string firstName, string lastName)
                => (FirstName, LastName) = (firstName, lastName);

            // Deconstructor
            public void Deconstruct(out string firstName, out string lastName)
                => (firstName, lastName) = (FirstName, LastName);
        }*/

        static void Main()
        {
            // Construct record
            var person = new Person("Oleg", "Kyrylchuk");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

            // Deconstruct record
            var (firstName, lastName) = person;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}
