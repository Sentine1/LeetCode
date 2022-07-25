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

            var inputA = new int[] { 5, 7, 7, 8, 8, 10 };
            var inputB = inputA;
            var inputC = new int[] { };
            var outputA = new int[] { 3, 4 };
            var outputB = new int[] { -1, -1 };
            var outputC = outputB;

            Assert.AreEqual(outputA, task.SearchRange(inputA, 8));
            Assert.AreEqual(outputB, task.SearchRange(inputB, 6));
            Assert.AreEqual(outputC, task.SearchRange(inputC, 0));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
