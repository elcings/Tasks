using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class RemoveDublicateService
    {
        //public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        //{
        //    return enumerable.GroupBy(keySelector).Select(grp => grp.First());
        //}
        public static void RemoveDuplicates(List<int> list)
        {
            list.Sort();
            int index = list.Count - 1;
            while (index > 0)
            {
                if (list[index] == list[index - 1])
                {
                    if (index < list.Count - 1)
                        (list[index], list[list.Count - 1]) = (list[list.Count - 1], list[index]);
                    list.RemoveAt(list.Count - 1);
                    index--;
                }
                else
                    index--;
            }
         }
    }
}
