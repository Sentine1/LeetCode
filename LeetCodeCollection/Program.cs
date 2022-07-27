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

            var inputA = new TreeNode(3, 5, 1, 6, 2, 0, 8, null, null, 7, 4);
            TreeNode inputB = null;
            var inputC = new TreeNode();
            var outputA = new TreeNode(1, null, 2, null, 3, null, 4, null, 5, null, 6);
            TreeNode outputB = null;
            var outputC = new TreeNode();
            task.Flatten(inputA);
            task.Flatten(inputB);
            task.Flatten(inputC);

            Assert.AreEqual(outputA, inputA);
            Assert.AreEqual(outputB, inputB);
            Assert.AreEqual(outputC, inputC);

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
