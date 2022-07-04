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

            var inputA = new[] { 1, 0, 2};
            var inputB = new[] { 1, 2, 2 };
            var inputC = new[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(5, task.Candy(inputA), "wrong answer");
            Assert.AreEqual(4, task.Candy(inputB), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
