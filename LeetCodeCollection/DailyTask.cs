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
            public bool IsPowerOfThree(int n)
            {
                var log = Math.Round(Math.Log(n, 3), 1, MidpointRounding.ToEven);
                var pow = Math.Pow(3, log);
                Console.WriteLine($"log - {log}, CallBack = {pow}");
                return n == pow && !double.IsInfinity(log);
            }
        }
    }
}
