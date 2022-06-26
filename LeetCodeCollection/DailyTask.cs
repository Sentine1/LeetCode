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
            public int MaxScore(int[] cardPoints, int k)
            {
                long sum = 0;
                foreach (var e in cardPoints)
                {
                    sum += e;
                }

                int ans = 0;
                int n = cardPoints.Length;
                int windowSize = n - k;
                int l = 0;
                int r = 0;
                long windowSum = 0;

                while (r < n)
                {
                    int right = cardPoints[r++];
                    windowSum += right;
                    while (r - l > windowSize)
                    {
                        int left = cardPoints[l++];
                        windowSum -= left;
                    }
                    if (r - l == windowSize)
                    {
                        ans = Math.Max(ans, (int)(sum - windowSum));
                    }
                }
                return ans;
            }
        }
    }
}