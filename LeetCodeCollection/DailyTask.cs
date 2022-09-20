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
            public int FindLength(int[] nums1, int[] nums2)
            {
                checked
                {
                    int max = 0;
                    int[,] dp = new int[nums1.Length, nums2.Length];

                    for (int i = 0; i < nums1.Length; i++)
                    {
                        for (int j = 0; j < nums2.Length; j++)
                        {
                            if (i == 0 || j == 0)
                            {
                                dp[i, j] = (nums1[i] == nums2[j] ? 1 : 0);
                                max = Math.Max(max, dp[i, j]);
                                continue;
                            }

                            if (nums1[i] == nums2[j])
                            {
                                dp[i, j] = dp[i - 1, j - 1] + 1;
                                max = Math.Max(max, dp[i, j]);
                                continue;
                            }

                            dp[i, j] = 0;
                        }
                    }

                    return max;
                }
            }
        }
    }
}