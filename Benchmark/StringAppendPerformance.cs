using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Text;

namespace Benchmark
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringAppendPerformance
    {
        [Params(10, 20)]
        public int value1;

        [Params(30, 40)]
        public int value2;

        private int init = 0;

        // before benchmarks
        [GlobalSetup]
        public void GlobalSetup()
        {
            init = 5;
        }

        // after benchmarks
        [GlobalCleanup]
        public void GlobalCleanup()
        {
            init = 0;
        }

        [Benchmark]
        public void MethodX()
        {
            Thread.Sleep(init + value1 + value2);
        }

        [Benchmark]
        public void MethodY()
        {
            Thread.Sleep(5 * init + value1 + value2);
        }
    }
}
