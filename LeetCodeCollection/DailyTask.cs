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
                var ans = -1;
                if (s.Length == 0)
                    return ans;

                var dict = new Dictionary<char, (int, int)>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                        dict[s[i]] = (dict[s[i]].Item1 + 1, dict[s[i]].Item2);
                    else dict.Add(s[i], (1, i));
                }

                foreach (var element in dict)
                {
                    if (element.Value.Item1 == 1)
                        return element.Value.Item2;
                }
                return ans;
            }
        }
    }
}
