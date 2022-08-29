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
            public int NumIslands(char[][] grid)
            {
                var ans = 0;
                if (grid.Length > 0)
                for (int x = 0; x < grid.Length; x++)
                {
                    for (int y = 0; y < grid[0].Length; y++)
                    {
                            if (grid[x][y] == '1')
                                while ((x + y) % 1 == 0)
                                {
                                    if (grid[x][y] == '0')
                                        ans++;
                                }
                    }
                }
                return ans;
            }
        }
    }
}
