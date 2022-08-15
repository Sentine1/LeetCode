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
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }
                };

                for (var i = 0; i < s.Length ; i++)
                {
                    if (i < s.Length - 1 && dict[s[i]] < dict[s[i + 1]])
                        ans -= dict[s[i]]; 
                    else ans += dict[s[i]];
                }
                return ans;
            }
        }
    }
}
