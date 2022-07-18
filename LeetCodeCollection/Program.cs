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

            var inputA = new int[][] { new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 }, new int[] { 0, 1, 0 } };
            var inputB = new int[][] { new int[] { 1, -1 }, new int[] { -1, 1 } };
            var inputC = new int[][] { new int[] { 904 } };

            Assert.AreEqual(4, task.NumSubmatrixSumTarget(inputA, 0));
            Assert.AreEqual(5, task.NumSubmatrixSumTarget(inputB, 0));
            Assert.AreEqual(0, task.NumSubmatrixSumTarget(inputC, 0));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
