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
            public int SingleNonDuplicate(int[] nums)
            {
                var answer = 0;

                foreach (var element in nums)
                {
                    answer ^= element;
                }

                return answer;
            }
        }
    }
}