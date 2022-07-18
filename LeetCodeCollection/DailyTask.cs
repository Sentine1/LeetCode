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
            public int NumSubmatrixSumTarget(int[][] matrix, int target)
            {
                var rows = matrix.Length;
                var columns = matrix[0].Length;
                var sum = new int[columns];

                int answer = 0;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        sum[col] = 0;
                    }

                    for (int subRow = row; subRow < rows; subRow++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            sum[col] += matrix[subRow][col];
                        }

                        var preSet = new Dictionary<int, int>();

                        int preSum = 0;
                        preSet.Add(preSum, 1);

                        for (int col = 0; col < columns; col++)
                        {
                            preSum += sum[col];

                            int search = preSum - target;

                            if (preSet.ContainsKey(search))
                            {
                                answer += preSet[search];
                            }

                            if (!preSet.ContainsKey(preSum))
                                preSet.Add(preSum, 0);

                            preSet[preSum]++;
                        }
                    }
                }

                return answer;
            }
        }
    }
}