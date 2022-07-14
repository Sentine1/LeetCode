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

            var inputA = (new int[]{ 3, 9, 20, 15, 7 }, new int[]{ 9, 3, 15, 20, 7 });
            var inputB = (new int[] { -1 }, new int[] { -1 });

            var outputA = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var outputB = new TreeNode(-1);

            Assert.AreEqual(outputA, task.BuildTree(inputA.Item1,inputA.Item2));
            Assert.AreEqual(outputB, task.BuildTree(inputB.Item1, inputB.Item2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
