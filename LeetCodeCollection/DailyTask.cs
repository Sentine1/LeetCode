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
            public int LongestConsecutive(int[] nums)
            {
                Array.Sort(nums);
                var result = 1;
                var currentSeq = 1;

                if (nums.Length < 1)
                    return 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] == nums[i] - 1)
                        currentSeq++;
                    if (nums[i - 1] != nums[i] - 1 && nums[i - 1] != nums[i])
                        currentSeq = 1;
                    result = Math.Max(currentSeq, result);
                }

                return result;
            }
        }
    }
}