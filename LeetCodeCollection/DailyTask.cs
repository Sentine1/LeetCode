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
            public int Rob(int[] nums)
            {
                var (p2, p) = (0, 0);
                foreach (var n in nums) (p2, p) = (p, Math.Max(p, p2 + n));
                return p;
            }
        }
    }
}