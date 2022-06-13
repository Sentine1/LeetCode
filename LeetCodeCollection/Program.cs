using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> a = new [] { new List<int>{2}, new List<int> { 3, 4}, new List<int> { 6, 5, 7}, new List<int> { 4, 1, 8, 3} };
            IList<IList<int>> b = new [] { new List<int>{ -10 } };
            var dailyTask = new DailyTask.Solution();
            Assert.IsTrue(dailyTask.MinimumTotal(
                a) == 11);
            Assert.IsTrue(dailyTask.MinimumTotal(
                b) == -10);
            Console.ReadKey();
        }
    }
}
