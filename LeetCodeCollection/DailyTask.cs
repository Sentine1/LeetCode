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
            public int CountVowelPermutation(int n)
            {
                int mod = (int) 1e9+7;
                var count = new long[5] { 1, 1, 1, 1, 1 };
                for (int i = 2; i < n + 1; i++)
                {
                    var countTemp = new long[5];
                    countTemp[0] = count[1];
                    countTemp[1] = (count[0] + count[2]) % mod;
                    countTemp[2] = (count[0] + count[1] + count[3] + count[4]) % mod;
                    countTemp[3] = (count[2] + count[4]) % mod;
                    countTemp[4] = count[0];
                    count = countTemp;
                }

                return (int)(count.Sum() % mod);
            }
        }
    }
}