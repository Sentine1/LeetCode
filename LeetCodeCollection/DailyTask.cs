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
            public IList<string> FindAndReplacePattern(string[] words, string pattern)
            {
                var patternSeq = Helper(pattern);
                var ans = new List<string>();
                foreach (var word in words)
                {
                    if (patternSeq == Helper(word))
                    {
                        ans.Add(word);
                    }
                }
                return ans;
            }

            private string Helper(string s)
            {
                IDictionary<char, char> old2New = new Dictionary<char, char>();
                StringBuilder sb = new StringBuilder(s);

                char curr = 'a';

                for (int i = 0; i < s.Length; i++)
                {
                    if (!old2New.ContainsKey(sb[i]))
                    {
                        old2New[sb[i]] = curr++;
                    }

                    sb[i] = old2New[sb[i]];
                }

                return sb.ToString();
            }
        }
    }
}