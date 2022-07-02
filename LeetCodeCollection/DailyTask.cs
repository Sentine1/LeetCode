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
            public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
            {
                long mod = 1000000007;
                var maxHorizontal = 0;
                var maxVertical = 0;
                var previous = 0;
                foreach (var item in horizontalCuts.OrderBy(x => x))
                {
                    maxHorizontal = Math.Max(item - previous, maxHorizontal);
                    previous = item;
                }

                maxHorizontal = Math.Max(h - previous, maxHorizontal);
                previous = 0;

                foreach (var item in verticalCuts.OrderBy(x => x))
                {
                    maxVertical = Math.Max(item - previous, maxVertical);
                    previous = item;
                }
                maxVertical = Math.Max(w - previous, maxVertical);

                return (int)(maxVertical % mod * maxHorizontal % mod);
            }
        }
    }
}