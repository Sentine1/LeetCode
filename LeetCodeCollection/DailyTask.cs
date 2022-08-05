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
            public int CombinationSum4(int[] nums, int target)
            {
                int[] dp = new int[target + 1];
                dp[0] = 1;

                for (int i = 1; i < dp.Length; i++)
                {
                    foreach (int num in nums)
                    {
                        if (i - num >= 0)
                            dp[i] += dp[i - num];
                    }
                }

                return dp[target];
            }
        }
    }
}