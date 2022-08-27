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
            public int MaxSumSubmatrix(int[][] matrix, int k)
            {
                var m = matrix.Length;
                var n = matrix[0].Length;
                var preSum = new int[m + 1, n + 1];

                for (int i = 1; i <= m; ++i)
                    for (int j = 1; j <= n; ++j)
                        preSum[i, j] += preSum[i - 1, j] + preSum[i, j - 1] - preSum[i - 1, j - 1] + matrix[i - 1][j - 1];

                var ans = -111111;

                for (int sr = 1; sr <= m; ++sr)
                    for (int sc = 1; sc <= n; ++sc)
                        for (int er = sr; er <= m; ++er)
                            for (int ec = sc; ec <= n; ++ec)
                            {
                                var area = preSum[er, ec] - preSum[sr - 1, ec] - preSum[er, sc - 1] + preSum[sr - 1, sc - 1];
                                if (area <= k)
                                    ans = Math.Max(ans, area);
                            }

                return ans;

            }
        }
    }
}
