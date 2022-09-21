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
            public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
            {
                var lenght = queries.Length;
                var answer = new int[lenght];
                var summCurent = 0;
                foreach (var num in nums)
                {
                    if (num % 2 == 0)
                        summCurent += num;
                }

                for (int i = 0; i < queries.Length; i++)
                {
                    var n = queries[i][1];
                    var temp = nums[n];
                    nums[n] += queries[i][0];
                    if (temp % 2 == 0)
                        summCurent -= temp;

                    if (nums[n] % 2 == 0)
                        summCurent += nums[n];

                    answer[i] = summCurent;
                }

                return answer;
            }
        }
    }
}