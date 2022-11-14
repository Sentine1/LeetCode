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

            var inputA = new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } };
            var inputB = new[] { new[] { 0, 0 }, new[] { 0, 2 },  new[] { 1, 1 }, new[] { 2, 0 }, new[] { 2, 2 } };
            var inputC = new[] { new[] { 0, 0 } };

            Assert.AreEqual(5, task.RemoveStones(inputA));
            Assert.AreEqual(3, task.RemoveStones(inputB));
            Assert.AreEqual(0, task.RemoveStones(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
