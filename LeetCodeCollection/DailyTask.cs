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
            bool isSquare = false;
            public bool Makesquare(int[] nums)
            {
                isSquare = false;
                var n = nums.Length;
                if (n < 4) return false;
                var sum = nums.Sum();
                Array.Sort(nums);
                Array.Reverse(nums);
                if (sum % 4 != 0)
                {
                    return false;
                }

                var len = sum / 4;
                if (nums.Any(num => num > len)) return false;

                var current = new int[4] { len, len, len, len };

                DFS(nums, 0, current);

                return isSquare;
            }

            private void DFS(int[] nums, int start, int[] current)
            {
                if (current.All(num => num == 0)) isSquare = true;

                if (isSquare) return;

                var cur = nums[start];

                for (int j = 0; j < 4; j++)
                {
                    if (current[j] - cur >= 0)
                    {
                        current[j] -= cur;
                        DFS(nums, start + 1, current);
                        current[j] += cur;
                    }
                }
            }
        }
    }
}