using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // var lst = MaxValueService.GenerateListOfInt(-99000, 199000, 200000);
            // var result =await MaxValueService.MaxValueHavingNegativeBrother(lst);
              List<int> lst = new List<int>() { 1, 2, 3, 1, 1, 2 };
              RemoveDublicateService.RemoveDuplicates(lst);

            lst.ForEach(x =>
            {
                Console.WriteLine(x);
            });
             
           
            // List<int> lst = new List<int>() { -7, 2, 1, 4, 5 };
            //var res= await  MinPositiveService.MinPositiveIntNotInArray(lst);

            //  BenchmarkRunner.Run<MaxValueBenchMark>();

            Console.ReadLine();
        }
    }
}
