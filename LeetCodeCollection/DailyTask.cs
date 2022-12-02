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
            public bool CloseStrings(string word1, string word2)
            {
                HashSet<char> set = new(word2);
                int[] freq1 = new int[26], freq2 = new int[26];
                for (int i = 0; i < word1.Length; i++)
                {
                    freq1[word1[i] - 'a']++;
                    if (set.Add(word1[i])) 
                        return false;
                }
                for (int i = 0; i < word2.Length; i++)
                    freq2[word2[i] - 'a']++;

                Array.Sort(freq1);
                Array.Sort(freq2);

                return freq1.SequenceEqual(freq2);
            }
        }
    }
}