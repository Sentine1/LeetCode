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
            var outputA = "leEeetcode";
            var outputB = "abBAcC";
            var outputC = "s";

            Assert.AreEqual("leetcode", task.MakeGood(outputA));
            Assert.AreEqual("" , task.MakeGood(outputB));
            Assert.AreEqual("s", task.MakeGood(outputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
