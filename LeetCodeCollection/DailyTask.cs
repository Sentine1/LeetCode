using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int SingleNonDuplicate(int[] nums)
            {
                var left = 0;
                var right = nums.Length - 1;

                while (left<right)
                {
                    var mid = (left + right) / 2;
                    if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
                        left = mid + 1;
                    else right = mid;
                }

                return nums[left];
            }
        }
    }
}