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

            var inputA = new int[] { 1, -1, -2, 4, -7, 3 };
            var inputB = new int[] { 10, -5, -2, 4, 0, 3 };
            var inputC = new int[] { 1, -5, -20, 4, -1, 3, -6, -3 };

            Assert.AreEqual(7, task.MaxResult(inputA, 2));
            Assert.AreEqual(17, task.MaxResult(inputB, 3));
            Assert.AreEqual(0, task.MaxResult(inputC, 2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
