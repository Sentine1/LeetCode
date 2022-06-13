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
            public int MinimumTotal(IList<IList<int>> triangle)
            {
                for (int i = triangle.Count() - 2; i >= 0; i--)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        if (triangle[i + 1][j] > triangle[i + 1][j + 1])
                        {
                            triangle[i][j] = triangle[i + 1][j + 1] + triangle[i][j];
                        }
                        else
                        {
                            triangle[i][j] = triangle[i + 1][j] + triangle[i][j];
                        }
                    }
                }
                return triangle[0][0];
            }
        }
    }
}
