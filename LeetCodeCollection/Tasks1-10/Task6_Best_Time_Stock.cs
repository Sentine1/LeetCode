using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    public class Task6_Best_Time_Stock
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                var profit = 0;
                var current_min_price = prices[0];
                for(int i = 0; i < prices.Length; i++)
                {
                    var price = prices[i];
                    profit = Math.Max(profit,price - current_min_price);
                    current_min_price = Math.Min(current_min_price, price);
                }
                return profit;
            }
        }
    }
}
