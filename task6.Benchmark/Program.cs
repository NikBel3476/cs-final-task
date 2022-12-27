using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using task6;

namespace MyBenchmarks
{
    public class SortVsStdSort
    {
        private const int N = 100000;
        private readonly string[] testArray;
        private readonly string[] testArray2;

        public SortVsStdSort()
        {
            
            
            testArray = new string[N];
            for (int i = 0; i < N; i++)
            {
                testArray[i] = Guid.NewGuid().ToString();
            }

            testArray2 = testArray.Clone() as string[];
        }

        [Benchmark]
        public string[] Sort() => SortService.Sort(testArray);

        [Benchmark]
        public string[] StdSort()
        {
            Array.Sort(testArray2);
            return testArray2;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortVsStdSort>();
        }
    }
}