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
            public bool IsUgly(int n)
            {
                if (n <= 0)
                {
                    return false;
                }

                foreach (int factor in new int[] { 2, 3, 5 })
                {
                    n = KeepDividingWhenDivisible(n, factor);
                }

                return n == 1;
            }

            int KeepDividingWhenDivisible(int dividend, int divisor)
            {
                while (dividend % divisor == 0)
                {
                    dividend /= divisor;
                }
                return dividend;
            }
        }
    }
}