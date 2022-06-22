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
            public int FindKthLargest(int[] nums, int k)
            {
                var sorted = new SortedList<int, int>();

                foreach (var numer in nums)
                {
                    if (sorted.ContainsKey(numer))
                        sorted[numer]++;
                    else sorted.Add(numer, 0);
                }

                var elementK = 0;

                for (int i = 0; i < k; i++)
                {
                    elementK = sorted.Keys.Last();
                    if (sorted[elementK] < 1)
                        sorted.Remove(sorted.Keys.Last());
                    else
                        sorted[elementK]--;
                }
                return elementK;
            }
        }
    }
}