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
            public int RemoveDuplicates(int[] nums)
            {
                if (nums.Length < 1)
                    return 0;
                int n = 1;
                var j = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[j] < nums[i])
                    {
                        n++;
                        nums[++j] = nums[i];
                    }
                }
                return data[0][d - 1];
            }
        }
    }
}