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
            var inputA = defTree.BuildTree(new int?[] { 5, 3, 6, 2, 4, null, 7 });
            var inputB = defTree.BuildTree(new int?[] { 5, 3, 6, 2, 4, null, 7 });

            Assert.AreEqual(true, task.FindTarget(inputA, 9));
            Assert.AreEqual(false, task.FindTarget(inputB, 28));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
