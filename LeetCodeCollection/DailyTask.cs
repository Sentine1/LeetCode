﻿using System;
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
            private class Heap<T>
            {
                private readonly IList<T> _data;
                private readonly IComparer<T> _comparer;

                public int Count => _data.Count;
                public T Top => _data[0];

                public void Foreach(Action<T> kernel)
                {
                    foreach (var d in _data)
                    {
                        kernel?.Invoke(d);
                    }
                }

                public Heap() : this(new List<T>(), null)
                {
                }

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

                public T ExtractTop()
                {
                    T top = Top;
                    _data[0] = _data.Last();
                    _data.RemoveAt(Count - 1);
                    SiftDown(0);
                    return top;
                }

                public void Add(T value)
                {
                    _data.Add(value);
                    SiftUp(Count - 1);
                }
            }

            public bool IsPossible(int[] nums)
            {
                IDictionary<int, Heap<int>> val2SequenceLength = new Dictionary<int, Heap<int>>();

                for (int i = 0; i < nums.Length; i++)
                {
                    var curr = nums[i];
                    var prev = curr - 1;
                    int currentCount = 1;

                    if (val2SequenceLength.ContainsKey(prev))
                    {
                        var sequences = val2SequenceLength[prev];
                        int prevCount = sequences.ExtractTop();
                        currentCount = prevCount + 1;

                        if (sequences.Count == 0)
                        {
                            val2SequenceLength.Remove(prev);
                        }
                    }

                    if (!val2SequenceLength.ContainsKey(curr))
                    {
                        val2SequenceLength[curr] = new Heap<int>();
                    }

                    val2SequenceLength[curr].Add(currentCount);
                }

                bool valid = true;
                foreach (var kv in val2SequenceLength)
                {
                    kv.Value.Foreach(length => { valid = valid && (length >= 3); });
                }

                return valid;
            }
        }
    }
}
