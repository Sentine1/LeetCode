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
            public bool CanConstruct(string ransomNote, string magazine)
            {
                var CharArray = new int[256];
                foreach (var c in magazine)
                {
                    CharArray[c]++;
                }

                foreach (var c in ransomNote)
                {
                    CharArray[c]--;

                    if (CharArray[c] < 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
