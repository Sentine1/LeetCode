using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task18_Binary_Search
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                var right = nums.Length - 1;
                var left = 0;
                while (left <= right)
                {
                    var middle = left + (right - left) / 2;
                    if (nums[middle] == target)
                        return middle;
                    if (nums[middle] > target)
                        right = middle - 1;
                    else
                        left = middle + 1;
                }
                return -1;
            }
        }
    }
}