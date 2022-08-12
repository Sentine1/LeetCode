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
            var inputA = new TreeNode().BuildTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 });
            var inputB = new TreeNode().BuildTree(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 });
            var inputC = new TreeNode().BuildTree(new int?[] { 2, 1 });
            var inputD = new TreeNode().BuildTree(new int?[] { 2, 1, 3 });

            Assert.AreEqual(inputA, task.LowestCommonAncestor(inputA, inputA.left, inputA.right));
            Assert.AreEqual(inputA.left, task.LowestCommonAncestor(inputB, inputB.left, inputB.left.right));
            Assert.AreEqual(inputC, task.LowestCommonAncestor(inputC, inputC, inputC.left));
            Assert.AreEqual(inputD, task.LowestCommonAncestor(inputD, inputD.right, inputD.left));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
