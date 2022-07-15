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
            public int MaxAreaOfIsland(int[][] grid)
            {
                if (grid == null || grid.Length == 0)
                    return 0;

                int res = 0;
                int[] dx = new int[] { 0, 0, 1, -1 },
                      dy = new int[] { 1, -1, 0, 0 };

                for (int i = 0; i < grid.Length; i++)
                    for (int j = 0; j < grid[0].Length; j++)
                        if (grid[i][j] == 1)
                        {
                            int area = 1;
                            Queue<int[]> q = new Queue<int[]>();

                            q.Enqueue(new int[] { i, j });
                            grid[i][j] = -1;

                            while (q.Count > 0)
                            {
                                int[] cur = q.Dequeue();

                                for (int k = 0; k < 4; k++)
                                {
                                    int newX = cur[0] + dx[k],
                                        newY = cur[1] + dy[k];

                                    if (newX > -1 && newX < grid.Length && newY > -1 &&
                                        newY < grid[0].Length && grid[newX][newY] == 1)
                                    {
                                        area++;
                                        grid[newX][newY] = -1;
                                        q.Enqueue(new int[] { newX, newY });
                                    }
                                }
                            }

                            res = Math.Max(res, area);
                        }

                return res;
            }
        }
    }
}