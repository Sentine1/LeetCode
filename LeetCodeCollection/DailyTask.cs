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
            public bool IsInterleave(string s1, string s2, string s3)
            {
                int m = s1.Length, n = s2.Length;

                if (m + n != s3.Length)
                    return false;

                var invalid = new bool[m + 1, n + 1];

                return dfs(0, 0, 0);
           

            bool dfs(int i, int j, int k)
            {
                if (invalid[i,j])
                    return false;

                if (k == s3.Length)
                    return true;

                bool valid =
                    i < s1.Length && s1[i] == s3[k] && dfs(i + 1, j, k + 1) ||
                    j < s2.Length && s2[j] == s3[k] && dfs(i, j + 1, k + 1);

                if (!valid)
                    invalid[i,j] = true;

                return valid;
                } 
            }
        }
    }
}