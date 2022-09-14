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
            var defaultTree = new TreeNode();
            var inputA = defaultTree.BuildTree(new int?[]{ 2, 3, 1, 3, 1, null, 1 });
            var inputB = defaultTree.BuildTree(new int?[] { 2, 1, 1, 1, 3, null, null, null, null, null, 1 });
            var inputC = defaultTree.BuildTree(new int?[] { 9 });

            Assert.AreEqual(2, task.PseudoPalindromicPaths(inputA));
            Assert.AreEqual(1, task.PseudoPalindromicPaths(inputB));
            Assert.AreEqual(1, task.PseudoPalindromicPaths(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
