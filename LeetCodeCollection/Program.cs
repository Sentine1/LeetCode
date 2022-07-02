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

            var inputA = (5, 4, new int[] { 1, 2, 4 }, new int[] { 1, 3 });
            var inputB = (5, 4, new int[] { 3, 1 }, new int[] { 1 });
            var inputC = (5, 4, new int[] { 3 }, new int[] { 3 });
            var inputD = (1000000000, 1000000000, new[] { 2 }, new[] { 2 });

            Assert.AreEqual(4, task.MaxArea(inputA.Item1,inputA.Item2,inputA.Item3,inputA.Item4), "wrong answer");
            Assert.AreEqual(6, task.MaxArea(inputB.Item1, inputB.Item2, inputB.Item3, inputB.Item4), "wrong answer");
            Assert.AreEqual(9, task.MaxArea(inputC.Item1, inputC.Item2, inputC.Item3, inputC.Item4), "wrong answer");
            Assert.AreEqual(81, task.MaxArea(inputD.Item1, inputD.Item2, inputD.Item3, inputD.Item4), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
