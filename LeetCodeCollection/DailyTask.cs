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
            public bool CheckPossibility(int[] nums)
            {
                int? decreaseIDx = null;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i + 1] < nums[i])
                    {
                        if (decreaseIDx.HasValue)
                        {
                            return false;
                        }

                        decreaseIDx = i;
                    }
                }

                if (!decreaseIDx.HasValue)
                {
                    return true;
                }

                if (decreaseIDx.Value + 1 == nums.Length - 1 || nums[decreaseIDx.Value] <= nums[decreaseIDx.Value + 2])
                {
                    return true;
                }

                if (decreaseIDx.Value == 0 || nums[decreaseIDx.Value + 1] >= nums[decreaseIDx.Value - 1])
                {
                    return true;
                }

                return false;
            }
        }
    }
}