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
            var inputA = new[] { new[] { 1, 2, 3, 3 }, new[] { 3, 4, 5, 6 }, new[] { 50, 10, 40, 70 } };
            var inputB = new[] { new[] { 1, 2, 3, 4, 6 }, new[] { 3, 5, 10, 6, 9 }, new[] { 20, 20, 100, 70, 60 } };
            var inputC = new[] { new[] { 1, 1, 1 }, new[] { 2, 3, 4 }, new[] { 5, 6, 4 } };

            Assert.AreEqual(120, task.JobScheduling(inputA[0],inputA[1],inputA[2]));
            Assert.AreEqual(150, task.JobScheduling(inputB[0], inputB[1], inputB[2]));
            Assert.AreEqual(6, task.JobScheduling(inputC[0], inputC[1], inputC[2]));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
