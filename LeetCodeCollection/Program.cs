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
            var inputA = (new[] { 1, 2, 3, 4 }, new[] { new[] { 1, 0 }, new[] { -3, 1 }, new[] { -4, 0 }, new[] { 2, 3 } });
            var inputB = (new[] { 1 }, new[] { new[] { 4, 0 } });

            Assert.AreEqual(new[] { 8, 6, 2, 4 }, task.SumEvenAfterQueries(inputA.Item1, inputA.Item2));
            Assert.AreEqual(new[] { 0 }, task.SumEvenAfterQueries(inputB.Item1, inputB.Item2));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
