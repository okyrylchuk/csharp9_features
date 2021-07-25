namespace CovariantReturns
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1413226380402192385
    class Program
    {
        abstract class Cloneable
        {
            public abstract Cloneable Clone();
        }

        class Person : Cloneable
        {
            public string Name { get; set; }
            public override Person Clone()
            {
                return new Person { Name = Name };
            }

            static void Main(string[] args)
            {
                Person person = new Person { Name = "Oleg" };
                Person clonedPerson = person.Clone();
            }
        }
    }

    #region C#8 version
    // To run C#8 version uncomment code below, comment C#9 version
    // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
    /*class Program
    {
        abstract class Cloneable
        {
            public abstract Cloneable Clone();
        }

        class Person : Cloneable
        {
            public string Name { get; set; }
            public override Cloneable Clone()
            {
                return new Person { Name = Name };
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person { Name = "Oleg" };
            Person clonedPerson = (Person)person.Clone();
        }
    }*/
    #endregion
}
   