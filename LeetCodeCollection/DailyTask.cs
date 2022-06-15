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
            public bool check(String a, String b)
            {
                if (a.Length + 1 != b.Length) return false;
                int i = 0, j = 0, count = 0;
                while (i < a.Length && j < b.Length)
                {
                    if (a[i] == b[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        if (++count > 1) return false;
                        j++;
                    }
                }
                return true;
            }

            public int LongestStrChain(string[] words)
            {
                {
                    int n = words.Length;
                    int[] dp = new int[n];
                    Array.Fill(dp, 1);
                    int result = 0;
                    Array.Sort(words, (a, b) => a.Length - b.Length);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < i; j++)
                            if (check(words[j], words[i]) &&
                                dp[i] < dp[j] + 1)
                                dp[i] = dp[j] + 1;
                        result = Math.Max(result, dp[i]);
                    }
                    return result;
                }
            }
        }
    }
}