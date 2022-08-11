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
            var inputA = new int[] { -10, -3, 0, 5, 9 };
            var outputA = new TreeNode().BuildTree(new int?[] { 0, -3, 9, -10, null, 5 });
            var inputB = new int[] { 1, 3 };
            var outputB = new TreeNode().BuildTree(new int?[] { 3, 1 });

            var test = task.SortedArrayToBST(inputA);
            Console.WriteLine($"{outputA.GetHashCode()} A, {test.GetHashCode()} test");

            Assert.AreEqual(outputA, task.SortedArrayToBST(inputA));
            Assert.AreEqual(outputB, task.SortedArrayToBST(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
