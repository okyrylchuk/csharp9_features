namespace InitOnlySetters
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1412848899463733249
    class Program
    {
        class Person
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }

        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "Oleg",
                LastName = "Kyrylchuk"
            };

            person.FirstName = "New first name"; // immutable
            person.LastName = "New last name";   // immutable
        }
    }

    #region C#8 version
    // To run C#8 version uncomment code below, comment C#9 version
    // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
    //class Program
    //{
    //    class Person
    //    {
    //        public string FirstName { get; set; }
    //        public string LastName { get; set; }
    //    }

    //    static void Main(string[] args)
    //    {
    //        var person = new Person()
    //        {
    //            FirstName = "Oleg",
    //            LastName = "Kyrylchuk"
    //        };

    //        person.FirstName = "New first name"; // mutable 
    //        person.LastName = "New last name";   // mutable
    //    }
    //}
    #endregion
}
