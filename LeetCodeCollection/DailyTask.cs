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
            public int MinimumAverageDifference(int[] nums)
            {
                var dp = new int[nums.Length];
                int min = int.MaxValue;
                int answer = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    int sumA = 0, sumB = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (j <= i)
                            sumA += nums[j];
                        else sumB += nums[j];
                    }
                    sumA /= i + 1;
                    int calc = nums.Length - i - 1;
                    sumB = calc > 0 ? sumB / calc : 0;
                    int count = sumA - sumB < 0 ? (sumA- sumB)*-1: (sumA - sumB);

                    dp[i] = count;
                    if (min > count)
                        answer = i;
                    min = Math.Min(min, count);
                    
                }
                
                return answer;
            }
        }
    }
}