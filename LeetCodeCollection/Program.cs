using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { "a", "b", "ba", "bca", "bda", "bdca" };
            var b = new[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" };
            var c = new[] { "abcd", "dbqca" };
            var dailyTask = new DailyTask.Solution();
            Assert.IsTrue(dailyTask.LongestStrChain(
                a) == 4);
            Assert.IsTrue(dailyTask.LongestStrChain(
                b) == 5);
            Assert.IsTrue(dailyTask.LongestStrChain(
                c) == 1);
            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
