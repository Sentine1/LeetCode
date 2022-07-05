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

            var inputA = new[] { 100, 4, 200, 1, 3, 2};
            var inputB = new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int[] inputC = new int[] { };
            var inputD = new[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
            var inputE = new[] { 1, 2, 0, 1 };

            Assert.AreEqual(4, task.LongestConsecutive(inputA), "wrong answer");
            Assert.AreEqual(9, task.LongestConsecutive(inputB), "wrong answer");
            Assert.AreEqual(0, task.LongestConsecutive(inputC), "wrong answer");
            Assert.AreEqual(7, task.LongestConsecutive(inputD), "wrong answer");
            Assert.AreEqual(3, task.LongestConsecutive(inputE), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
