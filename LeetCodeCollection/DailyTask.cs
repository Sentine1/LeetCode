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
            public int NumFactoredBinaryTrees(int[] arr)
            {
                var mod = (int)(1e9 + 7);
                checked
                {

                    Array.Sort(arr);
                    int[] dp = new int[arr.Length];

                    IDictionary<int, int> val2Idx = new Dictionary<int, int>();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        val2Idx[arr[i]] = i;
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        dp[i] = 1;

                        for (int j = 0; j < i; j++)
                        {
                            if (arr[i] % arr[j] == 0)
                            {
                                int right = arr[i] / arr[j];
                                if (val2Idx.ContainsKey(right))
                                {
                                    var mult = (int)
                                        (((long)dp[j] * dp[val2Idx[right]]) % MODULO);
                                    dp[i] += mult;
                                    dp[i] %= mod;
                                }
                            }
                        }
                    }

                    int res = 0;
                    foreach (var d in dp)
                    {
                        res += d;
                        res %= mod;
                    }

                    return res;
            }
        }
    }
}