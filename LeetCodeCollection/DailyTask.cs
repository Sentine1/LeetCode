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
            public int NumberOfWeakCharacters(int[][] properties)
            {
                Array.Sort(properties, (a, b) => a[0] != b[0] ? a[0].CompareTo(b[0]) : b[1].CompareTo(a[1]));
                int result = 0;
                int currMax = int.MinValue;

                for (int i = properties.Length - 1; i >= 0; i--)
                {
                    if (properties[i][1] < currMax)
                        result++;
                    currMax = Math.Max(currMax, properties[i][1]);
                }
                return result;
            }
        }
    }
}
