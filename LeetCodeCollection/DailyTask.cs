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
            public string MakeGood(string s)
            {
                var resultWord = new StringBuilder(s);

                for (int i = 1; i < resultWord.Length; i++)
                {
                    if (checkWord(resultWord[i - 1], resultWord[i]))
                    {
                        resultWord.Remove(i - 1, 2);
                        i = 0;
                    }
                }

                bool checkWord(char a, char b)
                {
                    return Math.Abs(a - b) == 32;
                }

                return resultWord.ToString();
            }
        }
    }
}