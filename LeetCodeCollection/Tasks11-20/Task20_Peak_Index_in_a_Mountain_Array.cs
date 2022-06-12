using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task20_Peak_Index_in_a_Mountain_Array
    {
        public class Solution
        {
            public int PeakIndexInMountainArray(int[] nums)
            {
                var right = nums.Length - 1;
                var left = 0;
                while (left <= right)
                {
                    var middle = left + (right - left) / 2;
                    if (nums[middle] > nums[middle + 1])
                        right = middle - 1;
                    else
                        left = middle + 1;
                }
                return left;
            }
        }
    }
}
