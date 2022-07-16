﻿using System;
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
            const int mod = 1000000007;
            private static (int, int)[] dirs = { (1, 0), (0, 1), (-1, 0), (0, -1) };
            private int Helper(int?[,,] dp, int x, int y, int limit)
            {
                if (dp[x, y, limit].HasValue)
                {
                    return dp[x, y, limit].Value;
                }

                if (limit == 0)
                {
                    dp[x, y, limit] = 0;
                    return 0;
                }

                int res = 0;
                int nextLimit = limit - 1;

                foreach (var dir in dirs)
                {
                    int nextX = x + dir.Item1;
                    int nextY = y + dir.Item2;

                    if (nextX >= 0 && nextX < dp.GetLength(0) && nextY >= 0 && nextY < dp.GetLength(1))
                    {
                        int inner = Helper(dp, nextX, nextY, nextLimit);
                        res = res + inner;
                        res = res % mod;
                    }
                    else
                    {
                        res++;
                        res = res % mod;
                    }
                }

                dp[x, y, limit] = res;
                return res;
            }

            public int FindPaths(int m, int n, int limit, int startX, int startY)
            {
                if (m == 0 || n == 0 || limit == 0)
                {
                    return 0;
                }

                int?[,,] dp = new int?[m, n, limit + 1];
                return Helper(dp, startX, startY, limit);
            }
        }
    }
}