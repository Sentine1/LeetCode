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
            public int UniquePaths(int m, int n)
            {
                int[,] DP = new int[m, n];

                DP[0, 0] = 1;

                if (m > 1)
                    for (int i = 1; i <= DP.GetLength(0) - 1; i++)
                        DP[i, 0] = 1;

                if (n > 1)
                    for (int i = 1; i <= DP.GetLength(1) - 1; i++)
                        DP[0, i] = 1;

                for (int i = 1; i <= DP.GetLength(0) - 1; i++)
                    for (int j = 1; j <= DP.GetLength(1) - 1; j++)
                        DP[i, j] = DP[i - 1, j] + DP[i, j - 1];

                return DP[m - 1, n - 1];
            }
        }
    }
}