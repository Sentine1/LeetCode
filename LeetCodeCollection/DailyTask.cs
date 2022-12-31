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
            private readonly (int di, int dj)[] _directions = { (0, 1), (0, -1), (1, 0), (-1, 0) };

            private void Helper((int i, int j) cell, int[][] grid, bool[,] visited, ref int res, ref int emptyCounter)
            {
                int n = grid.Length;
                int m = grid[0].Length;

                if (grid[cell.i][cell.j] == 2 && emptyCounter == 0)
                {
                    res++;
                    return;
                }

                visited[cell.i, cell.j] = true;
                if (grid[cell.i][cell.j] == 0)
                {
                    emptyCounter--;
                }

                foreach (var dir in _directions)
                {
                    int newI = cell.i + dir.di;
                    int newJ = cell.j + dir.dj;

                    if (newI >= 0 && newI < n && newJ >= 0 && newJ < m && !visited[newI, newJ] && grid[newI][newJ] != -1)
                    {
                        Helper((newI, newJ), grid, visited, ref res, ref emptyCounter);
                    }
                }

                if (grid[cell.i][cell.j] == 0)
                {
                    emptyCounter++;
                }
                visited[cell.i, cell.j] = false;
            }

            public int UniquePathsIII(int[][] grid)
            {
                int n = grid.Length;
                if (n < 1)
                    return 0;
                int m = grid[0].Length;

                int res = 0;
                bool[,] visited = new bool[n, m];

                int emptyCount = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i][j] == 0)
                        {
                            emptyCount++;
                        }
                    }
                }


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            Helper((i, j), grid, visited, ref res, ref emptyCount);
                        }
                    }
                }
                return res;
            }
        }
    }
}