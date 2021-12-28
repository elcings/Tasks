using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
   public  class MinPositiveService
    {
        public async static Task<int> MinPositiveIntNotInArray(List<int> list)
        {
            return await Task.Run<int>(() =>
            {
                var lst = list.OrderBy(x => x).ToList();

                int smallEstPositive = 1;
                if (lst.Count() == 0) return smallEstPositive;
                if (lst[0] > 1) return smallEstPositive;
                if (lst[lst.Count() - 1] <= 0) return smallEstPositive;

                for (int i = 0; i < lst.Count(); i++)
                {
                    if (lst[i] == smallEstPositive)
                        smallEstPositive++;
                }
                return smallEstPositive;
            });
            
        }
    }
}
