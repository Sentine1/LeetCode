using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public bool UniqueOccurrences(int[] arr)
            {
                var group = arr.GroupBy(x => x);
                var counter = new HashSet<int>();
                foreach (var element in group)
                {
                    if (counter.Contains(element.Count()))
                        return false;
                    counter.Add(element.Count());
                }
                return true;
            }
        }
    }
}