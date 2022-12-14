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
            var InputA = new[] { 1, 2, 3, 1 };
            var InputB = new[] { 2, 7, 9, 3, 1 };

            Assert.AreEqual(4,  task.Rob(InputA));
            Assert.AreEqual(12, task.Rob(InputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
