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
            public int ConcatenatedBinary(int n)
            {
                long m = 1, res = 0, modulo = (long)1e9 + 7;
                for (int i = 1; i < n + 1; i++)
                {
                    if (i == m)
                        m <<= 1;
                    res = (res * m + i) % modulo;
                }
                return (int)res;
            }
        }
    }
}