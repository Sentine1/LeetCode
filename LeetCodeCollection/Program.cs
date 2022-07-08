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

            var inputA = (new int[] { 0, 0, 0, 0, 0 }, new int[][] { new[] { 1, 10 }, new[] { 10, 1 }, new[] { 10, 1 }, new[] { 1, 10 }, new[] { 5, 1 } });
            var inputB = (new int[] { 0, 2, 1, 2, 0 }, new int[][] { new[] { 1, 10 }, new[] { 10, 1 }, new[] { 10, 1 }, new[] { 1, 10 }, new[] { 5, 1 } }); ;
            var inputC = (new int[] { 3, 1, 2, 3 }, new int[][] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }); ;

            Assert.AreEqual(9, task.MinCost(inputA.Item1, inputA.Item2, 5, 2, 3));
            Assert.AreEqual(11, task.MinCost(inputB.Item1, inputB.Item2, 5, 2, 3));
            Assert.AreEqual(-1, task.MinCost(inputC.Item1, inputC.Item2, 4, 3, 3));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
