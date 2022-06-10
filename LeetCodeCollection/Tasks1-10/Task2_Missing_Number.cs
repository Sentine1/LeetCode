using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task2_Missing_Number
    {
        public class Solution
        {
            public int MissingNumber(int[] nums)
            {
                var count = nums.Length;
                return count * (count + 1) / 2 - nums.Sum();
            }
        }
    }
}
