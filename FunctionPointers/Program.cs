namespace FunctionPointers
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1417892125912489985
    class Program
    {
        unsafe class Example
        {
            // This method has a managed calling convention.
            // This is the same as leaving the 'managed' keyword off.
            delegate*<int, void> functionPointer1;

            // The same as functionPointer1, but with explicit 'managed' keyword
            delegate* managed<int, void> functionPointer2;

            // This method will be invoked using whatever the default unmanaged calling
            // convention on the runtime platform is. This is platform and architecture
            // dependent and is determined by the CLR at runtime.
            public delegate* unmanaged<int, void> functionPointer3;
        }

        static void Main(string[] args)
        {
        }
    }
}
