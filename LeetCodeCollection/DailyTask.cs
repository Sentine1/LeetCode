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
            public int KthSmallest(int[][] matrix, int k)
            {
                return matrix.SelectMany(x => x)
                    .OrderBy(x => x)
                    .ElementAt(k - 1);
            }
        }
    }
}