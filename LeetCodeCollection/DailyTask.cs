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
                var stack = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                        stack.Push(s[i]);

                    if (s[i] == ' ' || i + 1 == s.Length)
                    {
                        while (stack.Count > 0)
                        {
                            answer.Append(stack.Pop());
                        }
                        
                        if (s[i] == ' ')
                            answer.Append(s[i]);
                    }
                }
                return answer.ToString();
            }
        }
    }
}