using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task1_Contains_Duplicate
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> seens = new HashSet<int>();
                    foreach(var e in nums)
                {
                    if (seens.Contains(e))
                        return true;
                    seens.Add(e);
                }
                return false;
            }
        }
    }
}
