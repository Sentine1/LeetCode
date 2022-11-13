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
                var answer = new StringBuilder();
                var words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = words.Count -1; i > -1; i--)
                {
                    answer.Append(words[i] + " ");
                }
                return answer.ToString().Trim();
            }
        }
    }
}