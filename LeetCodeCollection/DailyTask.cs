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
            /// <summary>
            /// Find position non repeat char
            /// </summary>
            /// <param name="s"></param>
            /// <returns>position in string</returns>

            public int FirstUniqChar(string s)
            {
                int[] h =  new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    h[s[i] - 97]++;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (h[s[i] - 97] == 1)
                        return i;
                }
                return -1;
            }
        }
    }
}
