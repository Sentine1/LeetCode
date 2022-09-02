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
            var tree = new TreeNode();
            var inputA = tree.BuildTree(new int?[] { 3, 1, 4, 3, null, 1, 5 });
            var inputB = tree.BuildTree(new int?[] { 3, 3, null, 4, 2 });
            var inputC = tree.BuildTree(new int?[] { 1 });

            Assert.AreEqual(4, task.GoodNodes(inputA));
            Assert.AreEqual(3, task.GoodNodes(inputB));
            Assert.AreEqual(1, task.GoodNodes(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
