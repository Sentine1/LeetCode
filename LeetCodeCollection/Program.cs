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
            var InputA = defTree.BuildTree(new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13 });
            var InputB = defTree.BuildTree(new int?[] { 1, null, 2, null, 0, 3 });
            var InputC = defTree.BuildTree(new int?[] { 1, 2, null, 3 });



            Assert.AreEqual(7,  task.MaxAncestorDiff(InputA));
            Assert.AreEqual(2, task.MaxAncestorDiff(InputB));
            Assert.AreEqual(2, task.MaxAncestorDiff(InputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
