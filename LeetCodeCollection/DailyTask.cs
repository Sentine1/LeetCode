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
            public bool SearchMatrix(int[][] matrix, int target)
            {
                int currentRow = 0, currentCol = matrix[0].Length - 1;

                while (currentRow <= matrix.GetLength(0) - 1 && currentCol >= 0)
                    if (matrix[currentRow][currentCol] == target)
                        return true;
                    else if (matrix[currentRow][currentCol] < target)
                        currentRow++;
                    else if (matrix[currentRow][currentCol] > target)
                        currentCol--;

                return false;
            }
        }
    }
}