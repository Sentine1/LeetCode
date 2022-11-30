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
            var defTree = new TreeNode();

            var inputA = new[] { 1, 2, 2, 1, 1, 3 };
            var inputB = new[] { 1, 2 };
            var inputC = new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };

            Assert.AreEqual(true, task.UniqueOccurrences(inputA));
            Assert.AreEqual(false, task.UniqueOccurrences(inputB));
            Assert.AreEqual(true, task.UniqueOccurrences(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
