using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    class Task8_Range_Sum_Query
    {
        public class NumArray
        {
            private List<int> sums = new List<int>();

            public NumArray(int[] nums)
            {
                var current_sum = 0;
                foreach (var num in nums)
                {
                    current_sum += num;
                    sums.Add(current_sum);
                }

            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                    return sums[right];
                return sums[right] - sums[left - 1];
            }
        }

        /**
         * Your NumArray object will be instantiated and called as such:
         * NumArray obj = new NumArray(nums);
         * int param_1 = obj.SumRange(left,right);
         */
    }
}
