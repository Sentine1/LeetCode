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
            var inputA = new[] { 2, 4 };
            var inputB = new[] { 2, 4, 5, 10 };

            Assert.AreEqual(3, task.NumFactoredBinaryTrees(inputA));
            Assert.AreEqual(7, task.NumFactoredBinaryTrees(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
