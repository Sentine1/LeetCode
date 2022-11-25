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
            public int SumSubarrayMins(int[] arr)
            {
                int i = 0;
                long ans = 0;
                Stack<int> stack = new Stack<int>();

                while (i < arr.Length || stack.Count > 0)
                {
                    if (stack.Count == 0 || (i < arr.Length && arr[i] > arr[stack.Peek()]))
                        stack.Push(i++);
                    else
                    {
                        int idx = stack.Pop();
                        int start = stack.Count == 0 ? -1 : stack.Peek();
                        int end = i < arr.Length ? i - idx : arr.Length - idx;
                        ans += (idx - start) * end * (long)arr[idx];
                    }
                }

                return (int)(ans % 1000000007);
            }
        }
    }
}