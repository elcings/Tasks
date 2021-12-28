using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class MaxValueService
    {
        public static List<int> GenerateListOfInt(int minVal, int maxVal, int size)
        {
            Random rnd = new Random();
            List<int> randomVals = new List<int>();
            for (int i = 0; i < size; i++)
            {
                int rndVal = rnd.Next(minVal, maxVal);
                randomVals.Add(rndVal);
            }
            return randomVals;
        }
        public async static Task<int> MaxValueHavingNegativeBrother(List<int> list)
        {
            return await Task.Run<int>(()=>
            {

                list = list.OrderBy(x => x).ToList();
                int res = 0;
                int l = 0, r = list.Count() - 1;
                while (l < r)
                {
                    int sum = list[l] + list[r];
                    if (sum == 0)
                    {
                        return list[r];
                    }
                    if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }

                }
                return res;

            });
           
        }
    }
}
