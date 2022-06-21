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
            public int FurthestBuilding(int[] heights, int bricks, int ladders)
            {
                int sum = 0;
                var queue = new SortedSet<(int Height, int Index)>();
                for (int i = 1; i < heights.Length; i++)
                {
                    if (heights[i] <= heights[i - 1]) continue;
                    queue.Add((heights[i] - heights[i - 1], i));
                    if (queue.Count > ladders)
                    {
                        sum += queue.Min.Height;
                        queue.Remove(queue.Min);
                    }
                    if (sum > bricks)
                        return i - 1;
                }
                return heights.Length - 1;
            }
        }
    }
}