using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    class Task7_Maximum_Subarray
    {
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                int maximum_sum = nums[0];
                int current_sum = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    var num = nums[i];

                    current_sum = Math.Max(current_sum + num, num);
                    maximum_sum = Math.Max(maximum_sum, current_sum);
                }
                return maximum_sum;
            }
        }
    }
}
