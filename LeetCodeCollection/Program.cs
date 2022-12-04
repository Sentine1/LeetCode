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
            var InputA = new[] { 2, 5, 3, 9, 5, 3 };
            var InputB = new[] { 0 };
            var InputC = new[] { 1, 2, 3, 4, 5 };


            Assert.AreEqual(3, task.MinimumAverageDifference(InputA));
            Assert.AreEqual(0, task.MinimumAverageDifference(InputB));
            Assert.AreEqual(0, task.MinimumAverageDifference(InputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
