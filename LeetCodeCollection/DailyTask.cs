using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution        {
            public int MaxResult(int[] nums, int k)
            {

                int[] scores = new int[nums.Length];
                var queue = new LinkedList<int>();
                scores[0] = nums[0];
                queue.AddLast(0);
                for (int i = 1; i < nums.Length; i++)
                {
                    if (queue.First() < i - k)
                    {
                        queue.RemoveFirst();
                    }
                    scores[i] = scores[queue.First()] + nums[i];
                    while (queue.Count > 0 && scores[queue.Last()] <= scores[i])
                    {
                        queue.RemoveLast();
                    }
                    queue.AddLast(i);
                }
                return scores[nums.Length - 1];
            }
        }
    }
}