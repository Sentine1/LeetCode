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
            HashSet<char> dict =  new HashSet<char>(new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            public bool HalvesAreAlike(string s)
            {
                var mid = s.Length / 2;
                var count = 0;
                for (int i = 0; i < mid; i++)
                {
                    if (dict.Contains(s[i]))
                        count++;
                }

                for (int i = mid; i < s.Length; i++)
                {
                    if (dict.Contains(s[i]))
                        count--;
                }

                return count == 0;
            }
        }
    }
}