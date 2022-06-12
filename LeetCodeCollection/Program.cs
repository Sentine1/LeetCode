using NUnit.Framework;
using System;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dailyTask = new DailyTask.Solution();
            Assert.IsTrue(dailyTask.MaximumUniqueSubarray(
                new[] { 4, 2, 4, 5, 6 }) == 17);
            Assert.IsTrue(dailyTask.MaximumUniqueSubarray(
                new[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 }) == 8);
            Console.ReadKey();
        }
    }
}
