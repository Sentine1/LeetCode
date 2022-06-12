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
            public int MaximumUniqueSubarray(int[] nums)
            {
                var summ = 0;
                var temp = 0;
                var position = 0;
                var hash = new HashSet<int>();
                for (int i = 0; i < nums.Length;)
                {
                    if (hash.Contains(nums[i]))
                    {
                        hash.Remove(nums[position]);
                        temp -= nums[position];
                        position++;
                    }
                    else
                    {
                        hash.Add(nums[i]);
                        temp += nums[i];
                        summ = Math.Max(temp, summ);
                        i++;
                    }
                }
                return summ;
            }
        }
    }
}
