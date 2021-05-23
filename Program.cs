using BenchmarkDotNet.Running;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            var bench = BenchmarkRunner.Run<Benchmark>();
        }
    }
}