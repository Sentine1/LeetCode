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
            public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
            {
                return buckets == 1 ? 0 : (int)Math.Ceiling(Math.Log(buckets, (minutesToTest / minutesToDie) + 1));
            }
        }
    }
}