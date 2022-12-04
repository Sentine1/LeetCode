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
            public int MinimumAverageDifference(int[] nums)
            {
                long lSum = 0, rSum = 0, l = 0, r = nums.Length, localMin = long.MaxValue, gMin = long.MaxValue, idx = 0;

                foreach (var v in nums)
                    rSum += v;

                for (int i = 0; i < nums.Length; i++)
                {
                    lSum += nums[i];
                    rSum -= nums[i]; 
                    ++l; --r;
                    localMin = Math.Abs((lSum / l) - (rSum / (r == 0 ? 1 : r)));
                    if (localMin < gMin)
                    {
                        gMin = localMin;
                        idx = i;
                    }
                }

                return (int)idx;
            }
        }
    }
}