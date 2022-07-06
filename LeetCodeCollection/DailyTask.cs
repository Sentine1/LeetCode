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
            public int Fib(int n)
            {
                if (n < 1) return 0;
                if (n < 3) return 1;
                int[] dp = new int [n+1];
                dp[1] = 1; dp[2] = 1;
                for (int i = 3; i <= n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }
                return dp[n];
            }
        }
    }
}