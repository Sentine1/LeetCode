using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    class Task27_Pacific_Atlantic_Water_Flow
    {
        public class Solution
        {
            public IList<IList<int>> PacificAtlantic(int[][] mat)
            {
                List<IList<int>> res = new();
                int m = mat.Length, n = mat[0].Length;

                bool[,] isPacific = new bool[m, n];
                bool[,] isAtlantic = new bool[m, n];

                for (int row = 0; row < m; row++)
                {
                    DFS(row, 0, mat, isPacific, mat[row][0]);
                    DFS(row, n - 1, mat, isAtlantic, mat[row][n - 1]);
                }

                for (int col = 0; col < n; col++)
                {
                    DFS(0, col, mat, isPacific, mat[0][col]);
                    DFS(m - 1, col, mat, isAtlantic, mat[m - 1][col]);
                }

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        if (isPacific[i, j] && isAtlantic[i, j])
                            res.Add(new List<int> { i, j });

                return res;
            }

            private void DFS(int row, int col, int[][] mat, bool[,] reach, int prev)
            {
                int m = mat.Length, n = mat[0].Length;

                if (row < 0 || row >= m || col < 0 || col >= n || reach[row, col] || mat[row][col] < prev)
                    return;
                reach[row, col] = true;
                DFS(row, col + 1, mat, reach, mat[row][col]);
                DFS(row, col - 1, mat, reach, mat[row][col]);
                DFS(row + 1, col, mat, reach, mat[row][col]);
                DFS(row - 1, col, mat, reach, mat[row][col]);
            }
        }
    }
}
