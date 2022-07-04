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
            public int Candy(int[] ratings)
            {
                var n = ratings.Length;
                int[] candies = new int[n];
                Array.Fill(candies, 1);

                for (int i = 1; i <n ; i++)
                {
                    // higher rated child gets 1 more candy than left lower rated child
                    if (ratings[i] > ratings[i - 1]) candies[i] = (candies[i - 1] + 1);
                }

                for (int i = n - 2; i >= 0; i--)
                {
                    // higher rated child gets 1 more candy than right lower rated child
                    if (ratings[i] > ratings[i + 1]) candies[i] = Math.Max(candies[i], (candies[i + 1] + 1));
                }

                int sum = 0;
                foreach (int candy in candies)
                    sum += candy;
                return sum;
            }
        }
    }
}