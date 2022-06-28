using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int MinDeletions(string s)
            {
                if (s == null || s == string.Empty)
                    return 0;

                var res = 0;
                var curFreq = Int32.MaxValue;
                Dictionary<char, int> dict = new Dictionary<char, int>();

                foreach (var c in s)
                {
                    if (!dict.ContainsKey(c))
                        dict.Add(c, 0);
                    dict[c] ++;
                }

                foreach (var item in dict
                         .OrderByDescending(x => x.Value)
                         .Select(x => x.Value)
                         .ToList())
                    if (curFreq <= item)
                    {
                        res += curFreq == 0 ? item : item - curFreq + 1;
                        curFreq = curFreq == 0 ? 0 : curFreq - 1;
                    }
                    else
                        curFreq = item;

                return res;
            }
        }
    }
}