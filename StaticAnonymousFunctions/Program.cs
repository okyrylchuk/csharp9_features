using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace StaticAnonymousFunctions
{
    // Example from tweet https://twitter.com/okyrylchuk/status/1415008120926097411
    class Program
    {
        [MemoryDiagnoser]
        public class Benchmark
        {
            [Benchmark]
            public void AnounymousFunction()
            {
                var list = new List<int> { 1, 2, 3 };
                int y = 2;
                list.ForEach(x => x *= y);
            }

            [Benchmark]
            public void StaticAnounymousFunction()
            {
                var list = new List<int> { 1, 2, 3 };
                const int y = 2;
                list.ForEach(static x => x *= y);
            }
        }

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
