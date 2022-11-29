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
            public class RandomizedSet
            {

                List<int> values;

                public RandomizedSet()
                {
                    values = new List<int>();
                }

                public bool Insert(int val)
                {
                    if (values.Contains(val))
                        return false;
                    values.Add(val);
                    return true;
                }

                public bool Remove(int val)
                {
                    if (!values.Contains(val))
                        return false;
                    values.Remove(val);
                    return true;
                }

                public int GetRandom()
                {
                    var n = values.Count;
                    var rnd = new Random();
                    var index = rnd.Next(n);
                    return values[index];
                }
            }

            /**
             * Your RandomizedSet object will be instantiated and called as such:
             * RandomizedSet obj = new RandomizedSet();
             * bool param_1 = obj.Insert(val);
             * bool param_2 = obj.Remove(val);
             * int param_3 = obj.GetRandom();
             */
        }
    }
}