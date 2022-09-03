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
            public int[] NumsSameConsecDiff(int n, int k)
            {
                Queue<int> numbers = new(Enumerable.Range(1, 9));

                for (int length = 1; length < n; ++length)
                    for (int i = numbers.Count - 1; i >= 0; --i)
                    {
                        var node = numbers.Dequeue();

                        int last = node % 10;

                        if (k == 0)
                            numbers.Enqueue(node * 10 + last);
                        else
                        {
                            if (last - k >= 0)
                                numbers.Enqueue(node * 10 + last - k);

                            if (last + k <= 9)
                                numbers.Enqueue(node * 10 + last + k);
                        }
                    }

                return numbers.ToArray();
            }
        }
    }
}
