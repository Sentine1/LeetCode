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
            /// I       1
            /// V       5
            /// X       10
            /// L       50
            /// C       100
            /// D       500
            /// M       1000
            /// </summary>
            /// <param name="s"></param>
            /// <returns>Romanian number to int</returns>
            public int RomanToInt(string s)
            {
                var ans = 0;
                
                var dict = new Dictionary<char, int>()
                {
                    { ' ', 0 }, 
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }
                };
                var prev = ' ';
                foreach (var ch in s)
                {
                    if (dict.ContainsKey(ch))
                        if (dict[prev] >= dict[ch])
                            ans += dict[ch];
                        else
                            ans += -(dict[prev] * 2) + dict[ch];
                    else return -1;
                    prev = ch;
                }
                return ans;
            }
        }
    }
}
