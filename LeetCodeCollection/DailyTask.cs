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
            public string BreakPalindrome(string palindrome)
            {
                if (palindrome.Length < 2) return "";
                var charArray = palindrome.ToCharArray();

                for (int i = 0; i < charArray.Length / 2; i++)
                {
                    if (charArray[i] != 'a')
                    {
                        charArray[i] = 'a';
                        return new string(charArray);
                    }
                }

                charArray[charArray.Length - 1] = 'b';
                return new string(charArray);
            }
        }
    }
}