using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class task9_Counting_Bits
    {
        public class Solution
        {
            public int[] CountBits(int n)
            {
                var memo = new int[n+1];
                for (int i = 1; i < n + 1; i++)
                {
                    memo[i] = memo[i >> 1] + i % 2;
                }
                return memo.ToArray();
            }
        }
    }
}
