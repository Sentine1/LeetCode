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
            private bool IsSubsequence(string s, ref string t)
            {
                if (s.Length > t.Length)
                {
                    return false;
                }

                if (s.Length == 0)
                {
                    return true;
                }

                int i = 0;
                int j = 0;

                while (true)
                {
                    if (i == s.Length)
                    {
                        return true;
                    }

                    if (j == t.Length)
                    {
                        return false;
                    }

                    if (s[i] == t[j])
                    {
                        i++;
                        j++;
                        continue;
                    }

                    j++;
                }
            }

            public int NumMatchingSubseq(string s, string[] words)
            {
                int answer = 0;
                IDictionary<string, int> wordDict = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    if (!wordDict.ContainsKey(word))
                    {
                        wordDict[word] = 0;
                    }

                    wordDict[word]++;
                }

                foreach (var word in wordDict)
                {
                    if (IsSubsequence(word.Key, ref s))
                    {
                        answer += word.Value;
                    }
                }
                return answer;
            }
        }
    }
}