using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    [MemoryDiagnoser]
    public class MaxValueBenchMark
    {

        static List<int> lst = MaxValueService.GenerateListOfInt(-99000, 199000, 200000);
        [Benchmark]
        public void MaxValue()
        {
             MaxValueService.MaxValueHavingNegativeBrother(lst);
        }
    }
}
