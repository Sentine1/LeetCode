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
            var inputB = inputA;
            var inputC = new TreeNode(1,2);

            Assert.AreEqual(3, task.LowestCommonAncestor(inputA, new TreeNode (5),new TreeNode(1)));
            Assert.AreEqual(5, task.LowestCommonAncestor(inputB, new TreeNode(5), new TreeNode(4)));
            Assert.AreEqual(1, task.LowestCommonAncestor(inputC, new TreeNode(1), new TreeNode(2)));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
