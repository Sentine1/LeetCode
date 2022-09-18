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
            var inputA = (new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            var inputB = (new[] { 4, 2, 0, 3, 2, 5 });

            Assert.AreEqual(6, task.Trap(inputA));
            Assert.AreEqual(9, task.Trap(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
