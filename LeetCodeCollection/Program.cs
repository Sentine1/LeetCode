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

            var inputA = new int[] { 2, 2, 2, 0, 0 };
            var inputB = new int[] { 1, 3, 3, 0, 1 };

            Assert.AreEqual(6, task.FindPaths(inputA[0], inputA[1], inputA[2], inputA[3], inputA[4]));
            Assert.AreEqual(12, task.FindPaths(inputB[0], inputB[1], inputB[2], inputB[3], inputB[4]));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
