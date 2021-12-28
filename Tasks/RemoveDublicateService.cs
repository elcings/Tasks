using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class RemoveDublicateService
    {
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return enumerable.GroupBy(keySelector).Select(grp => grp.First());
        }
        public static void RemoveDuplicates(List<int> list)
        {
            var lst = list.DistinctBy<int,int>(i=>i).ToList();
            list.RemoveAll(x => true);
            list.AddRange(lst);
        }
    }
}
