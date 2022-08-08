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
            var inputA = new[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            var inputB = new[] { 0, 1, 0, 3, 2, 3 };
            var inputC = new[] { 7, 7, 7, 7, 7, 7, 7 };

            Assert.AreEqual(4, task.LengthOfLIS(inputA));
            Assert.AreEqual(4, task.LengthOfLIS(inputB));
            Assert.AreEqual(1, task.LengthOfLIS(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
