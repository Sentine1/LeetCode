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
            public int MaximumUnits(int[][] boxTypes, int truckSize)
            {
                boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();
                int ans = 0;
                var n = boxTypes.Length;

                for (int i = 0; i < n && truckSize > 0; i++)
                {
                    int maxi = Math.Min((int)boxTypes[i][0], truckSize);
                    ans += maxi * boxTypes[i][1];
                    truckSize -= maxi;
                }
                return ans;
            }
        }
    }
}