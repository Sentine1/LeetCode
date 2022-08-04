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
            public int MirrorReflection(int p, int q)
            {
                if (p == q) return 1;
                if (q == 0) return 0;

                int count = 0;
                while (((count + 1) * q) % p != 0) count++;

                if (count % 2 != 0) return 2;
                else if ((((count + 1) * q) / p) % 2 != 0) return 1;
                else return 0;
            }
        }
    }
}