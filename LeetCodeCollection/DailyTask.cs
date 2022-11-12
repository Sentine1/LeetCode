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
        public class MedianFinder
        {
            List<double> CollectionMF;
            int n;

            public MedianFinder()
            {
                CollectionMF = new List<double>();
                n = 0;
            }

            public void AddNum(int num)
            {

                if (n > 0 && num > CollectionMF[n - 1])
                    CollectionMF.Add(num);         
                else
                {
                    int pos = findPos(num);
                    CollectionMF.Insert(pos, num);
                }
                n++;
            }

            public double FindMedian()
            {
                if (n % 2 == 0)
                {
                    int mid = n / 2;
                    return (CollectionMF[mid - 1] + CollectionMF[mid]) / 2;
                }
                else
                {
                    return CollectionMF[n / 2];
                }
            }

            int findPos(double target)
            {
                int lo = 0;
                int hi = n - 1;

                while (lo < hi)
                {
                    int mid = (lo + hi) >> 1;
                    if (target > CollectionMF[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }

                return lo;
            }
        }
        public class Solution
        {
            public int RemoveDuplicates(int[] nums) => nums.Distinct().Count();
        }
    }
}