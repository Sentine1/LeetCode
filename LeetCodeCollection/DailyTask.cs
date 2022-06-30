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
            public int MinMoves2(int[] nums)
            {
                Array.Sort(nums);
                var n = nums.Length - 1;
                var i = 0;
                var answer = 0;

                for(;i<n;i++,n--)
                {
                    answer += nums[n] - nums[i];
                }
                return answer;
            }
        }
    }
}