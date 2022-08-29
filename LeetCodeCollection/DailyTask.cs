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
            private int[] set;
            private int components;

            public int NumIslands(char[][] grid)
            {
                set = null;
                components = 0;
                if (grid == null || grid.Length == 0)
                    return 0;

                int[] dx = new int[] { 0, 0, 1, -1 },
                      dy = new int[] { 1, -1, 0, 0 };

                set = new int[grid.Length * grid[0].Length];

                for (int i = 0; i < set.Length; i++)
                    set[i] = i;

                for (int i = 0; i < grid.Length; i++)
                    for (int j = 0; j < grid[0].Length; j++)
                        if (grid[i][j] == '1')
                            components++;

                for (int i = 0; i < grid.Length; i++)
                    for (int j = 0; j < grid[0].Length; j++)
                        if (grid[i][j] == '1')
                            for (int k = 0; k < 4; k++)
                            {
                                int newX = i + dx[k],
                                    newY = j + dy[k];

                                if (newX > -1 && newX < grid.Length && newY > -1 && newY < grid[0].Length && grid[newX][newY] == '1')
                                    Union(newX * grid[0].Length + newY, i * grid[0].Length + j);
                            }

                return components;
            }

            private int Find(int x)
            {
                if (set[x] != x)
                    set[x] = Find(set[x]);

                return set[x];
            }

            private void Union(int x, int y)
            {
                int px = Find(x),
                    py = Find(y);

                if (px != py)
                {
                    set[py] = px;
                    components--;
                }
            }
        }
    }
}
