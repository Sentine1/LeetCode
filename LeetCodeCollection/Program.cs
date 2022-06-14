using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var a =("sea","eat");
            var b = ("leetcode", "etco");
            var dailyTask = new DailyTask.Solution();
            Assert.IsTrue(dailyTask.MinDistance(
                a.Item1,a.Item2) == 2);
            Assert.IsTrue(dailyTask.MinDistance(
                b.Item1,b.Item2) == 4);
            Console.ReadKey();
        }
    }
}
