namespace NativeSizedIntegers
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1417581217420021767
    class Program
    {
        static void Main()
        {
            // The compiler provides operations and conversions for
            // 'nint' and 'nuint' that are appropriate for integer types. 
            nint a = 10;
            nint b = 7;

            _ = a + b;
            _ = a - b;

            nuint c = 5;
            nuint d = 3;

            _ = c + d;
            _ = c - d;
        }

        #region C#8 version
        // To run C#8 version uncomment code below, comment C#9 version
        // And change <TargetFramework>netcoreapp3.1</TargetFramework> in csproj file
        /*static void Main()
        {
            // The native-sized integer types are represented internally
            // as the .NET types System.IntPtr and System.UIntPtr.
            // Unlike other numeric types, you can't use them as integer types.
            IntPtr a = 10; // you can initialize IntPtr a = new IntPtr(10);
            IntPtr b = 7;  // you can initialize IntPtr a = new IntPtr(7);

            _ = a + b;
            _ = a - b;

            UIntPtr c = 5; // you can initialize UIntPtr a = new UIntPtr(5);
            UIntPtr d = 3; // you can initialize UIntPtr a = new UIntPtr(3);

            _ = c + d;
            _ = c - d;
        }*/
        #endregion
    }
}
