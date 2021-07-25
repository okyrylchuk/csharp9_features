namespace Records
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1418310978358423552
    class Program
    {
        record Person
        {
            // No constructor required to initialize properties
            public string FirstName { get; init; } // immutable
            public string LastName { get; init; } // immutable
        }

        static void Main()
        {
            var person = new Person
            {
                FirstName = "Oleg",
                LastName = "Kyrylchuk"
            };

            // Use with-expression to create new record from existing
            // specifying the changes in the values of properties
            var bondPerson = person with { LastName = "Bond" };

            // Value base comparison
            var duplicatedPerson = new Person
            {
                FirstName = "Oleg",
                LastName = "Kyrylchuk"
            };
            person.Equals(duplicatedPerson); // true
            _ = person == duplicatedPerson;  // true
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*class Person
        {
            // The constructor is required to initialize properties
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FirstName { get; } // immutable
            public string LastName { get; }  // immutable
        }

        static void Main()
        {
            var person = new Person("Oleg", "Kyrylchuk");

            // No with-expression. The values to be copied
            // should be explicitly passed into the constructor
            var bondPerson = new Person(person.FirstName, "Bond");

            // Reference base comparison
            var duplicatedPerson = new Person("Oleg", "Kyrylchuk");
            person.Equals(duplicatedPerson); // false
            _ = person == duplicatedPerson;  // false
        }*/
        #endregion
    }
}
