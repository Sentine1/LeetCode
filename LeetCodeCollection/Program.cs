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

            Assert.AreEqual(new int [] { }, task.MovesToStamp("abca", "ababc"));
            Assert.AreEqual(new int[] { 0, 2}, task.MovesToStamp("abc", "ababc"));
            Assert.AreEqual(new[] { 3, 0, 1 }, task.MovesToStamp("abca", "aabcaca"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
