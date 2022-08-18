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
            public int MinSetSize(int[] arr)
            {
                List<(int val, int count)> data;
                var valDict = new Dictionary<int, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    var val = arr[i];
                    if (!valDict.ContainsKey(val))
                    {
                        valDict[val] = 0;
                    }
                    valDict[val]++;
                }

                data = new List<(int val, int count)>(valDict.Count);

                foreach (var p in valDict)
                {
                    data.Add((p.Key, p.Value));
                }

                data.Sort((d1, d2) => d2.count.CompareTo(d1.count));
                int answer = 0;
                int currCount = 0;

                foreach (var t in data)
                {
                    currCount += t.count;
                    answer++;
                    if (currCount >= arr.Length / 2)
                    {
                        break;
                    }
                }

                return answer;
            }
        }
    }
}
