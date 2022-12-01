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

            var inputA = "book";
            var inputB = "textbook";
            var inputC = "brtpds";

            Assert.AreEqual(true, task.HalvesAreAlike(inputA));
            Assert.AreEqual(false, task.HalvesAreAlike(inputB));
            Assert.AreEqual(true, task.HalvesAreAlike(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
