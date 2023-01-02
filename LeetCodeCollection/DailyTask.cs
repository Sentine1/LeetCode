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
            public bool DetectCapitalUse(string word)
            {
                var count = 0;
                var first = word[0] != word[0].ToString().ToLower()[0];
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != word[i].ToString().ToLower()[0])
                        count++;

                }
                if (count == word.Length || (first && count == 1) || count == 0)
                    return true;
                return false;
            }
        }
    }
}