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
<<<<<<< HEAD
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
=======
            public int MinimumLengthEncoding(string[] words)
            {
                ISet<string> hashSet = words.ToHashSet();
                foreach (var word in words)
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        var postfix = word.Substring(i, word.Length - i);
                        hashSet.Remove(postfix);
                    }
                }
                return hashSet.Any() ? hashSet.Sum(w => w.Length + 1) : 0;
>>>>>>> 6ba4456 (Daily 20.6.22)
            }
        }
    }
}