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
            public string PushDominoes(string dominoes)
            {
                int n = dominoes.Length;
                var l = new int[n];
                var r = new int[n];
                var q = new Queue<int>();
                for (int i = 0; i < n; i++)
                {
                    if (dominoes[i] == 'L')
                    {
                        l[i] = 1;
                        q.Enqueue(i);
                    }
                    else if (dominoes[i] == 'R')
                    {
                        r[i] = 1;
                        q.Enqueue(i);
                    }
                }
                var t = new char[n];
                Array.Fill(t, '.');
                for (int depth = 2; q.Count > 0; depth++)
                {
                    for (int size = q.Count; size > 0; size--)
                    {
                        int i = q.Dequeue();
                        if (l[i] != 0 && r[i] == 0)
                        {
                            t[i] = 'L';
                            if (i > 0 && l[i - 1] == 0 && (r[i - 1] == 0 || r[i - 1] == depth))
                            {
                                l[i - 1] = depth;
                                q.Enqueue(i - 1);
                            }
                        }
                        if (l[i] == 0 && r[i] != 0)
                        {
                            t[i] = 'R';
                            if (i < n - 1 && r[i + 1] == 0 && (l[i + 1] == 0 || l[i + 1] == depth))
                            {
                                r[i + 1] = depth;
                                q.Enqueue(i + 1);
                            }
                        }
                    }
                }
                return new string(t);
            }
        }
    }
}