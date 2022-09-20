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
            var inputA = (new[] { 1, 2, 3, 2, 1 }, new[] { 3, 2, 1, 4, 7 });
            var inputB = (new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 });
            var inputC = (new[] { 0, 0, 0, 0, 1 }, new[] { 1, 0, 0, 0, 0 });
            var inputD = (new[] { 0, 1, 1, 1, 1 }, new[] { 1, 0, 1, 0, 1 });
            var inputE = (new[] { 1, 2, 3, 2, 1 }, new[] { 3, 2, 1, 4 });

            Assert.AreEqual(3, task.FindLength(inputA.Item1, inputA.Item2));
            Assert.AreEqual(5, task.FindLength(inputB.Item1, inputB.Item2));
            Assert.AreEqual(4, task.FindLength(inputC.Item1, inputC.Item2));
            Assert.AreEqual(2, task.FindLength(inputD.Item1, inputD.Item2));
            Assert.AreEqual(3, task.FindLength(inputE.Item1, inputE.Item2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
