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
            public int MaxProfit(int k, int[] prices)
            {
                int n = prices.Length;
                if (n <= 1)
                    return 0;

                //if k >= n/2, then you can make maximum number of transactions.
                if (k >= n / 2)
                {
                    int maxPro = 0;
                    for (int i = 1; i < n; i++)
                    {
                        if (prices[i] > prices[i - 1])
                            maxPro += prices[i] - prices[i - 1];
                    }
                    return maxPro;
                }

                int[][] dp = new int[k + 1][];
                dp[0] = new int[n];
                for (int i = 1; i <= k; i++)
                {
                    dp[i] = new int[n];
                    int localMax = dp[i - 1][0] - prices[0];
                    for (int j = 1; j < n; j++)
                    {
                        dp[i][j] = Math.Max(dp[i][j - 1], prices[j] + localMax);
                        localMax = Math.Max(localMax, dp[i - 1][j] - prices[j]);
                    }
                }
                return dp[k][n - 1];
            }
        }
    }
}