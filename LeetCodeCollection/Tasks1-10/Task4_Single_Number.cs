using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task4_Single_Number
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                var answer = 0;
                foreach (var num in nums)
                    answer ^= num;
                return answer;
            }
        }
    }
}
