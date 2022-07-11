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

            var inputA = new TreeNode(1, new TreeNode(2, new TreeNode(5)), new TreeNode(3, null, new TreeNode(4)));
            var inputB = new TreeNode(1, null, new TreeNode(3));
            var inputC = new TreeNode();
            var inputD = new TreeNode(1, new TreeNode(2));

            Assert.AreEqual(new int[] { 1, 3, 4 }, task.RightSideView(inputA));
            Assert.AreEqual(new int[] { 1, 3 }, task.RightSideView(inputB));
            Assert.AreEqual(new List<int>(), task.RightSideView(inputC.right));
            Assert.AreEqual(new int[] { 1, 2 }, task.RightSideView(inputD));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
