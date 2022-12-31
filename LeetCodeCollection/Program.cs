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
            var InputA = new[] { new[] { 1, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 2, -1 } };
            var InputB = new[] { new[] { 1, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 2 } };
            var InputC = new[] { new[] { 0, 1 }, new[] { 2, 0 } };

            Assert.AreEqual(2, task.UniquePathsIII(InputA));
            Assert.AreEqual(4, task.UniquePathsIII(InputB));
            Assert.AreEqual(0, task.UniquePathsIII(InputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
