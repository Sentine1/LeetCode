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

            var inputA = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var inputB = new TreeNode(1);
            var inputC = new TreeNode().left;
            var outputA = new List<List<int>> { new List<int> { 3 }, new List<int> { 9, 20 }, new List<int> { 15, 7 } };
            var outputB = new List<List<int>> { new List<int> { 1 }};
            var outputC = new List<List<int>> { };

            Assert.AreEqual(outputA,task.LevelOrder(inputA));
            Assert.AreEqual(outputB, task.LevelOrder(inputB));
            Assert.AreEqual(outputC, task.LevelOrder(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
