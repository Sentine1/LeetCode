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
            public int MinDistance(string input, string target)
            {
                //int m = input.Length;
                //int n = target.Length;

                //int[,] dp = new int[m, n];
                //for (int i = 0; i < m; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        dp[i, j] = -1;
                //    }
                //}
                return bottomUpDp(input, target);
            }

            int bottomUpDp(String A, String B)
            {
                int m = A.Length, n = B.Length;
                int[] prev = new int[n + 1];

                for (int j = 1; j <= n; j++)
                {
                    prev[j] = j;
                }

                for (int i = 1; i <= m; i++)
                {
                    int[] curr = new int[n + 1];
                    curr[0] = i;
                    for (int j = 1; j <= n; j++)
                    {
                        if (A[i - 1] == B[j - 1])
                        {
                            curr[j] = prev[j - 1];
                        }
                        else
                        {
                            curr[j] = 1 + Math.Min(prev[j], curr[j - 1]);
                        }
                    }
                    prev = curr;
                }
                return prev[n];
            }
        }
    }
}