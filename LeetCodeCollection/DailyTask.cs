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
            public string LongestPalindrome(string s)
            {
            var ans = "";
            int maximum = 0;
            int n = s.Length;
            int left, right;
            for (int i = 0; i < n; i++)
            {
                left = right = i;
                while( left >=0 && right < n && s[left] == s[right])
                {
                    var currentLenght = right - left + 1;
                    if (currentLenght > maximum)
                    {
                        ans = s.Substring(left, currentLenght);
                        maximum = currentLenght;
                    }
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;

                while(left >= 0 && right < n && s[left] == s[right])
                {
                    var currentLenght = right - left + 1;
                    if (currentLenght > maximum)
                    {
                        ans = s.Substring(left, currentLenght);
                        maximum = currentLenght;
                    }
                    left --;
                    right ++;
                }
            }
            return ans;
            }
        }
    }
}