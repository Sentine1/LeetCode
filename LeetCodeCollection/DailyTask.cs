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
            public bool IsPowerOfFour(int n)
            {
                var a = Math.Log(n,4);

                var b = (int)a;
                return a == b;
            }
        }
    }
}
