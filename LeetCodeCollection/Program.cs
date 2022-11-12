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

            Assert.AreEqual(7, task.MinDifficulty(inputA, 2));
            Assert.AreEqual(-1, task.MinDifficulty(inputB, 4));
            Assert.AreEqual(3, task.MinDifficulty(inputC, 3));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
