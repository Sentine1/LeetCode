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
            var inputA = new[] { 6, 5, 4, 3, 2, 1 };
            var inputB = new[] { 9, 9, 9 };
            var inputC = new[] { 1, 1, 1 };

            Assert.AreEqual(7, task.MinDifficulty(inputA, 2));
            Assert.AreEqual(-1, task.MinDifficulty(inputB, 4));
            Assert.AreEqual(3, task.MinDifficulty(inputC, 3));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
