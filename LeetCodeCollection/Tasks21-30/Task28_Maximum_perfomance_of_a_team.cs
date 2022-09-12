using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LeetCodeCollection.Tasks21_30
{
    class Task28_Maximum_perfomance_of_a_team
    {
        public class Solution1
        {
            public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
            {
                int counter = 0, mod = (int)(1e9) + 7;
                List<Person> list = new List<Person>();
                for (int i = 0; i < speed.Length; i++)
                    list.Add(new Person(speed[i], efficiency[i]));

                // sort by efficiency
                list.Sort((x, y) => y.e - x.e);

                SortedSet<int> pq = new SortedSet<int>(Comparer<int>.Create(
                    (x, y) => {
                        int xSpeed = list[x].s, ySpeed = list[y].s;
                        return xSpeed != ySpeed ? xSpeed - ySpeed : y - x;
                    }
                ));

                long maxPerformance = 0, currSpeed = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (pq.Count == k)
                    {
                        // remove the person with the least speed
                        currSpeed -= list[pq.Min].s;
                        pq.Remove(pq.Min);
                    }

                    pq.Add(i);
                    var person = list[i];
                    currSpeed += person.s;

                    long currPerformance = (currSpeed * person.e);
                    maxPerformance = Math.Max(maxPerformance, currPerformance);
                }
                return (int)(maxPerformance % mod);
            }

            public class Person
            {
                // speed, efficiency
                public int s;
                public int e;

                public Person(int s, int e)
                {
                    this.s = s;
                    this.e = e;
                }
            }
        }

        //Gready sort and Heap
        public class Solution
        {
            private const int MODULO = 1_000_000_007;

            private class Heap<T>
            {
                private readonly IList<T> _data;
                private readonly IComparer<T> _comparer;

                public int Count => _data.Count;
                public T Peek => _data[0];

                public Heap(IList<T> inputs, IComparer<T> comparer = null)
                {
                    _comparer = comparer ?? Comparer<T>.Default;
                    _data = inputs;
                    for (int i = Count / 2; i >= 0; i--)
                    {
                        SiftDown(i);
                    }
                }

                public Heap(IEnumerable<T> inputs, IComparer<T> comparer = null) : this(inputs.ToList(), comparer)
                {
                }

                private void Swap(int i, int j)
                {
                    var tmp = _data[i];
                    _data[i] = _data[j];
                    _data[j] = tmp;
                }

                private void SiftDown(int i)
                {
                    while (2 * i + 1 < _data.Count)
                    {
                        int left = 2 * i + 1;
                        int right = 2 * i + 2;
                        int j = left;

                        if (right < _data.Count && _comparer.Compare(_data[right], _data[left]) < 0)
                        {
                            j = right;
                        }

                        if (_comparer.Compare(_data[i], _data[j]) <= 0)
                        {
                            break;
                        }

                        Swap(i, j);
                        i = j;
                    }
                }

                private void SiftUp(int i)
                {
                    while (_comparer.Compare(_data[i], _data[(i - 1) / 2]) < 0)
                    {
                        Swap(i, (i - 1) / 2);
                        i = (i - 1) / 2;
                    }
                }

                public T Pop()
                {
                    T top = Peek;
                    _data[0] = _data.Last();
                    _data.RemoveAt(Count - 1);
                    SiftDown(0);
                    return top;
                }

                public void Push(T value)
                {
                    _data.Add(value);
                    SiftUp(Count - 1);
                }
            }

            public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
            {
                checked
                {
                    List<(int s, int e)> data = new List<(int s, int e)>(n);
                    for (int i = 0; i < n; i++)
                    {
                        data.Add((speed[i], efficiency[i]));
                    }

                    data.Sort((d1, d2) =>
                    {
                        var cmp = d2.e.CompareTo(d1.e);
                        if (cmp != 0)
                        {
                            return cmp;
                        }

                        return d1.s.CompareTo(d2.s);
                    });

                    BigInteger res = 0;
                    BigInteger sum = 0;
                    Heap<int> heap = new Heap<int>(new List<int>(k));

                    BigInteger cand;

                    for (int i = 0; i < n; i++)
                    {
                        sum += data[i].s;
                        heap.Push(data[i].s);

                        if (heap.Count > k)
                        {
                            sum -= heap.Pop();
                        }

                        cand = (sum * data[i].e);
                        if (cand > res)
                        {
                            res = cand;
                        }
                    }

                    return (int)(res % MODULO);
                }
            }
        }
    }
}
