using System;
using System.Threading.Tasks;

// Example from tweet https://twitter.com/okyrylchuk/status/1413589024464424963

Console.WriteLine(args);
await Task.Delay(1000);
return 0;

#region C#8 version
// To run C#8 version uncomment code below, comment C#9 version
// And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
/*class Program
{
    static async Task<int> Main(string[] args)
    {
        Console.WriteLine(args);
        await Task.Delay(1000);
        return 0;
    }
}*/
#endregion