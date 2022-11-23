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
            public bool IsValidSudoku(char[][] board)
            {
                bool[,] rows = new bool[9, 10],
                cols = new bool[9, 10],
                boxes = new bool[9, 10];

                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                        if (board[i][j] != '.')
                        {
                            if (!rows[i, board[i][j] - 48] && !cols[j, board[i][j] - 48] && !boxes[(i / 3) * 3 + j / 3, board[i][j] - 48])
                            {
                                rows[i, board[i][j] - 48] = true;
                                cols[j, board[i][j] - 48] = true;
                                boxes[(i / 3) * 3 + j / 3, board[i][j] - 48] = true;
                            }
                            else
                                return false;
                        }

                return true;
            }
        }
    }
}