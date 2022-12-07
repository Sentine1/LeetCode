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
            var InputA = defTree.BuildTree(new int?[] { 10, 5, 15, 3, 7, null, 18 });
            var InputB = defTree.BuildTree(new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 });


            Assert.AreEqual(32, task.RangeSumBST(InputA,7,15));
            Assert.AreEqual(23, task.RangeSumBST(InputB,6,10));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
