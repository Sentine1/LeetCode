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
            var inputA = new TreeNode().BuildTree(new int?[] { 1, null, 2, null, null, 3 });
            var inputB = new TreeNode().BuildTree(new int?[] {});
            var inputC = new TreeNode().BuildTree(new int?[] { 1 });

            Assert.AreEqual(new List<int> { 1, 3, 2 }, task.InorderTraversal(inputA));
            Assert.AreEqual(new List<int> { }, task.InorderTraversal(inputB));
            Assert.AreEqual(new List<int> { 1 }, task.InorderTraversal(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
