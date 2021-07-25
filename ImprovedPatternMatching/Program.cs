using System;

namespace ImprovedPatternMatching
{
    class Program
    {
        // Type pattern matching
        // Example from tweet https://twitter.com/okyrylchuk/status/1413936703362961410
        static void MatchPatternByType(object o1, object o2)
        {
            var tuple = (o1, o2);
            if (tuple is (int, string))
            {
                Console.WriteLine("Pattern matched in if!");
            }
            // OR
            switch (tuple)
            {
                case (int, string):
                    Console.WriteLine("Pattern matched in switch!");
                    break;
            }
        }

        // Relational pattern matching
        // Example from tweet https://twitter.com/okyrylchuk/status/1414286714311483392
        static string GetCalendarSeason(int month) => month switch
        {
            >= 3 and < 6 => "spring",
            >= 6 and < 9 => "summer",
            >= 9 and < 12 => "autumn",
            12 or (>= 1 and < 3) => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(month),
                            $"Unexpected month: {month}."),
        };

        class Person { }

        static void Main()
        {
            MatchPatternByType(1, "test");

            // Pattern combinators
            // Example from tweet https://twitter.com/okyrylchuk/status/1414658759721459719
            // Example with 'not'
            Person person = null;
            if (person is not null) { }
            // Example with 'or' and 'and'
            bool IsLetter(char c) =>
                c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        }
    }

    #region C#8 version
    // To run C#8 version uncomment code below, comment C#9 version
    // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
    /*static void MatchPatternByType(object o1, object o2)
    {
        var tuple = (o1, o2);
        if (tuple.o1 is int && tuple.o2 is string)
        {
            Console.WriteLine("Pattern matched in if!");
        }
        // Or
        switch (tuple)
        {
            case var t when t.o1 is int && t.o2 is string:
                Console.WriteLine("Pattern matched in switch!");
                break;
        }
    }

    static string GetCalendarSeason(int month) => month switch
    {
        var m when m >= 3 && m < 6 => "spring",
        var m when m >= 6 && m < 9 => "summer",
        var m when m >= 9 && m < 12 => "autumn",
        var m when m == 12 || (m >= 1 && m < 3) => "winter",
        _ => throw new ArgumentOutOfRangeException(nameof(month),
                $"Unexpected month: {month}.")
    };

    class Person { }

    static void Main()
    {
        MatchPatternByType(1, "test");

        // Example with !
        Person person = new Person();
        if (!(person is null)) { }

        // Example with || and &&
        bool IsLetter(char c) =>
            c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
    }*/
    #endregion
}
