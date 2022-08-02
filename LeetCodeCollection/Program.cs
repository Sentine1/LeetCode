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
            var inputA = new int[][] { new[] { 1, 5, 9 }, new[] { 10, 11, 13 }, new[] { 12, 13, 15 } };
            var inputB = new int[][] { new int[] { -5 } };

            Assert.AreEqual(13, task.KthSmallest(inputA, 8));
            Assert.AreEqual(-5, task.KthSmallest(inputB, 1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
