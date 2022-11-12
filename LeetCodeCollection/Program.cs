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
            var inputA = new[] { 1, 1, 2 };
            var inputB = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var inputC = new[] { 1, 1, 1 };

            Assert.AreEqual(2, task.RemoveDuplicates(inputA));
            Assert.AreEqual(5, task.RemoveDuplicates(inputB));
            Assert.AreEqual(1, task.RemoveDuplicates(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
