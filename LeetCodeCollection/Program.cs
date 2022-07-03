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

            var inputA = new[] { 1, 7, 4, 9, 2, 5};
            var inputB = new[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 };
            var inputC = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Assert.AreEqual(6, task.WiggleMaxLength(inputA), "wrong answer");
            Assert.AreEqual(7, task.WiggleMaxLength(inputB), "wrong answer");
            Assert.AreEqual(2, task.WiggleMaxLength(inputC), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
