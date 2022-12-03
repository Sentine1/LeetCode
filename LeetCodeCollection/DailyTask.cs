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
            public string FrequencySort(string s)
            {
                return string.Join(string.Empty, s.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                    .ThenBy(x => x.Key)
                    .SelectMany(g => g)
                    .ToList());
            }
        }
    }
}