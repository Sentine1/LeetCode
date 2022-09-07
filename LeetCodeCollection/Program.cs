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
            var inputA = new TreeNode().BuildTree(new int?[] { 1, 2, 3, 4 });
            var inputB = new TreeNode().BuildTree(new int?[] { 1, 2, 3, null, 4 });

            Assert.AreEqual("1(2(4))(3)", task.Tree2str(inputA));
            Assert.AreEqual("1(2()(4))(3)", task.Tree2str(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
