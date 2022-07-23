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

            var inputA = new int[] { 5, 2, 6, 1 };
            var inputB = new int[] { -1 };
            var inputC = new int[] { -1, -1 };
            var outputA = new int[] { 2, 1, 1, 0 };
            var outputB = new int[] { 0 };
            var outputC = new int[] { 0, 0 };

            Assert.AreEqual(outputA, task.CountSmaller(inputA));
            Assert.AreEqual(outputB, task.CountSmaller(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
