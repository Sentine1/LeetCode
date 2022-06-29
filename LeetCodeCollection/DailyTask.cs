using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {        public class Solution
        {
            public int[][] ReconstructQueue(int[][] people)
            {
                var output = new List<int[]>();
                var sortedPeople = people
                    .OrderByDescending(x => x[0])
                    .ThenBy(x => x[1]);
                foreach (var p in sortedPeople)
                    output.Insert(p[1], p);

                return output.ToArray();
            }
        }
    }
}