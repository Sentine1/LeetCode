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

            var inputA = new[] { "amazon", "apple", "facebook", "google", "leetcode" };
            var inputB = inputA;
            var inputC = new[] { "amazon", "apple", "facebook", "google", "leetcode"};
            var outputA = new[] { "facebook", "google", "leetcode" };
            var outputB = new[] { "apple", "google", "leetcode" };
            var outputC = new[] { "google", "leetcode"};

            Assert.AreEqual(outputA, task.WordSubsets(inputA, new[] { "e", "o" }));
            Assert.AreEqual(outputB, task.WordSubsets(inputB, new[] { "l", "e" }));
            Assert.AreEqual(outputC, task.WordSubsets(inputC, new[] { "lo", "eo" }));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
