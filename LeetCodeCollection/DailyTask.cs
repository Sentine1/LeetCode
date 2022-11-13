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
            public string ReverseWords(string s)
            {
                return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Aggregate((x, y) => y + " " + x);
            }
        }
    }
}