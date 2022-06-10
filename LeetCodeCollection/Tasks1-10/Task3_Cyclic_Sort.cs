using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task3_Cyclic_Sort
    {
        public class Solution
        {
            public IList<int> FindDisappearedNumbers(int[] nums)
            {
                var answer = new List<int>();
                int i = 0;
                while (i < nums.Length)
                {
                    var position = nums[i] - 1;
                    if (nums[position] != nums[i])
                    {
                        var temp = nums[i];
                        nums[i] = nums[position];
                        nums[position] = temp;
                    }
                    else
                        i++;
                }

                for(i = 0; i< nums.Length; i++)
                {
                    if (nums[i] != i + 1)
                        answer.Add(i + 1);
                }

                return answer;
            }
        }
    }
}