using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public bool WordPattern(string pattern, string s)
            {
                var words = Regex.Split(s,@"\W+");
                var patternAndWord = new Dictionary<char, string>();
                var wordSet = new HashSet<string>();

                var n = pattern.Length;
                if (n != words.Length) return false;

                for (int i = 0; i < pattern.Length; i++)
                {
                    if (patternAndWord.ContainsKey(pattern[i]))
                    {
                        var curWord = patternAndWord[pattern[i]];
                        if (words[i] != curWord)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (wordSet.Contains(words[i])) return false;
                        patternAndWord[pattern[i]] = words[i];
                        wordSet.Add(words[i]);
                    }
                }

                return true;
            }
        }
    }
}