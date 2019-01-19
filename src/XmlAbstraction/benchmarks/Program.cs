namespace XmlAbstraction.Benchmark
{
    using BenchmarkDotNet.Running;
    
    public static class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<XmlObjectBenchmarks>();
        }
    }
}
