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

            var inputA = new int[] { 10, 15, 20 };
            var inputB = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var inputC = new int[] { 1, 5, 20, 4, 1, 3, 6, 3 };

            Assert.AreEqual(15, task.MinCostClimbingStairs(inputA));
            Assert.AreEqual(6, task.MinCostClimbingStairs(inputB));
            Assert.AreEqual(15, task.MinCostClimbingStairs(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
