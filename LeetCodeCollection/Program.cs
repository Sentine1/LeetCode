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

            var inputA = 2;
            var inputB = 3;
            var inputC = 4;

            Assert.AreEqual(1, task.Fib(inputA), "wrong answer");
            Assert.AreEqual(2, task.Fib(inputB), "wrong answer");
            Assert.AreEqual(3, task.Fib(inputC), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
