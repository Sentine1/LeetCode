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
            public bool IsAnagram(string s, string t)
            {
                var dict = new Dictionary<char,int> ();

                foreach (var chr in s)
                {
                    if (dict.ContainsKey(chr))
                        dict[chr]++;
                    else dict.Add(chr, 1);
                }
                foreach (var chr in t)
                {
                    if (dict.ContainsKey(chr) && dict[chr] > 0)
                    {
                        dict[chr]--;
                        if (dict[chr] == 0)
                            dict.Remove(chr);
                    }
                    else return false;
                }
                if (dict.Count == 0)
                    return true;
                else return false;
            }
        }
    }
}