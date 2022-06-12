using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class BigInput
    {
        public class Solution
        {
            public int MinOperations(int[] nums, int target)
            {
                int sumNums = 0, sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sumNums += nums[i];
                }
                if (sumNums == target)
                {
                    return nums.Length;
                }
                else if (sumNums < target)
                {
                    return -1;
                }
                target = sumNums - target;
                int left = 0, right = 0, length = -1;
                while (right < nums.Length)
                {
                    sum += nums[right++];
                    if (sum == target)
                    {
                        length = Math.Max(length, right - left);
                    }
                    while (sum > target)
                    {
                        sum -= nums[left++];
                        if (sum == target)
                        {
                            length = Math.Max(length, right - left);
                        }
                    }
                }
                if (length == -1)
                {
                    return -1;
                }
                return nums.Length - length;
            }
        }
    }
}
