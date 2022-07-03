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
            public int WiggleMaxLength(int[] nums)
            {
                var n = nums.Length;
                if (n == 1) 
                    return 1;
                int i = 0;
                while ((i + 1 < n) && nums[i] == nums[i + 1]) ++i;
                if (i == n - 1) 
                    return 1;
                bool increasing = nums[i + 1] > nums[i];
                int ans = 2;
                for (; i + 1 < n; ++i)
                {
                    if (increasing && nums[i + 1] < nums[i])
                    {
                        increasing = false;
                        ++ans;
                    }
                    if (!increasing && nums[i + 1] > nums[i])
                    {
                        increasing = true;
                        ++ans;
                    }
                }
                return ans;
            }
        }
    }
}