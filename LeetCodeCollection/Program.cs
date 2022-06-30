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

            var inputA = new int[] { 1, 2, 3 };
            var inputB = new int[] { 1, 10, 2, 9 };
            var inputC = new int[] { 1, 0, 0, 8, 6 };


            Assert.AreEqual(2, task.MinMoves2(inputA), "wrong answer");
            Assert.AreEqual(16, task.MinMoves2(inputB), "wrong answer");
            Assert.AreEqual(14, task.MinMoves2(inputC), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
