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
            public bool IsPossible(int[] target)
            {
                var sl = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
                long sum = 0;
                foreach (var t in target)
                {
                    Add(sl, t);
                    sum += t;
                }

                while (true)
                {
                    int max = sl.First().Key;
                    Remove(sl, max);
                    sum -= max;
                    if (max == 1 || sum == 1)
                        return true;
                    if (max < sum || sum == 0 || max % sum == 0)
                        return false;
                    max = (int)(max % sum);
                    sum += max;
                    Add(sl, max);
                }
            }

            public void Add(SortedList<int, int> lst, int num)
            {
                if (lst.ContainsKey(num))
                    lst[num]++;
                else
                    lst.Add(num, 1);
            }

            public void Remove(SortedList<int, int> lst, int num)
            {
                if (lst.ContainsKey(num))
                {
                    if (lst[num] == 1)
                        lst.Remove(num);
                    else
                        lst[num]--;
                }
            }
        }
    }
}