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
            var InputA = defTree.BuildTree(new int?[] { 1 });
            var InputB = defTree.BuildTree(new int?[] { 3, 9, 20, null, null, 15, 7 });
            var InputC = defTree.BuildTree(new int?[] { 1, 2 });
            var InputD = defTree.BuildTree(new int?[] { });

            Assert.AreEqual( new List<IList<int>>() {new [] { 1 }}, task.ZigzagLevelOrder(InputA));
            Assert.AreEqual( new List<IList<int>>() { new[] { 3 }, new[] { 20, 9 }, new[] { 15, 7 } }, task.ZigzagLevelOrder(InputB));
            Assert.AreEqual( new List<IList<int>>() { new[] { 1 }, new[] { 2 }}, task.ZigzagLevelOrder(InputC));
            Assert.AreEqual( new List<IList<int>>(), task.ZigzagLevelOrder(InputD));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
