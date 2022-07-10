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
            public int MinCostClimbingStairs(int[] cost)
            {
                var n = cost.Length;
                var dp = new int[n + 2];
                for (int i = 0; i < n; i++)
                {
                    dp[i + 2] = Math.Min(dp[i], dp[i + 1]) + cost[i];
                }
                return Math.Min(dp[n + 1], dp[n]);
            }
        }
    }
}