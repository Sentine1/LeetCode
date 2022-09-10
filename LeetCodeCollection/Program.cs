using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new DailyTask.Solution();
            var inputA = new[] { 2, 4, 1 };
            var inputB = new[] { 3, 2, 6, 5, 0, 3 };
            var inputC = new[] { 1, 2, 4 };

            Assert.AreEqual(2, task.MaxProfit(2, inputA));
            Assert.AreEqual(7, task.MaxProfit(2, inputB));
            Assert.AreEqual(3, task.MaxProfit(2, inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
