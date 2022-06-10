using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task5_Climbing_Stairs
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                if (n == 1)
                    return n;
                var n1 = 1;
                var n2 = 2;
                for (var i = 3; i < n + 1; i++)
                {
                    var temp = n2;
                    n2 = n1 + n2;
                    n1 = temp;
                }

                return n2;
            }
        }
    }
}
