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
            public int Trap(int[] height)
            {
                int n = height.Length, ans = 0;
                var left = new int[n];

                left[0] = height[0];

                for (int i = 1; i < n; i++)
                    left[i] = Math.Max(left[i - 1], height[i]);

                var right = new int[n];

                right[n - 1] = height[n - 1];

                for (int i = n - 2; i >= 0; i--)
                    right[i] = Math.Max(right[i + 1], height[i]);

                for (int i = 1; i < n - 1; i++)
                    ans += Math.Min(left[i], right[i]) - height[i];

                return ans;
            }
        }
    }
}