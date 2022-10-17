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
            public bool CheckIfPangram(string sentence)
            {
                var dictionary = new Dictionary<int, int>();
                foreach (var element in sentence)
                {
                    var current = element - 'a';
                    if (dictionary.ContainsKey(current))
                        dictionary[current]++;
                    else if (element - 'a' < 27)
                        dictionary.Add(current, 1);
                }
                if (dictionary.Count == 26)
                    return true;
                return false;
            }
        }
    }
}