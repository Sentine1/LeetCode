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

            var inputA = defTree.BuildTree(new int?[]{1, 2, 3, 4, 5, 6});
            var inputB = defTree.BuildTree(new int?[] { });
            var inputC = defTree.BuildTree(new int?[] { 1 });

            Assert.AreEqual(6, task.CountNodes(inputA));
            Assert.AreEqual(0, task.CountNodes(inputB));
            Assert.AreEqual(1, task.CountNodes(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
