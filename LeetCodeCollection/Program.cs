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
            var inputA = defTree.BuildTree(new int?[]{5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, null, 5, 1});
            var inputB = defTree.BuildTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }); ;
            var inputС = defTree.BuildTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }); ;
            var outputA = new[] { new[] { 5, 4, 11, 2 }, new[] { 5, 8, 4, 5 } };
            var outputB = new List<IList<int>>();
            var outputС = new List<IList<int>>();

            var ex = task.PathSum(inputA, 22);
            Assert.AreEqual(outputA, task.PathSum(inputA,22));
            Assert.AreEqual(outputB, task.PathSum(inputB, 5));
            Assert.AreEqual(outputС, task.PathSum(inputС, 0));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
