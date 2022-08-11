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
            var inputA = new TreeNode().BuildTree(new int?[] { 2, 1, 3 });
            var inputB = new TreeNode().BuildTree(new int?[] { 5, 1, 4, null, null, 3, 6 });
            var inputC = new TreeNode().BuildTree(new int?[] { 2, 2, 2 });
            var inputD = new TreeNode().BuildTree(new int?[] {2147483647});
            Assert.True(task.IsValidBST(inputA));
            Assert.False(task.IsValidBST(inputB));
            Assert.False(task.IsValidBST(inputC));
            Assert.True(task.IsValidBST(inputD));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
