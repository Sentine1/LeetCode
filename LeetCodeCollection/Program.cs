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

            var outputA = new int[][] { new int[] { 1 }, new int[] { 1, 1}, new int[] { 1, 2, 1}
            , new int[] { 1, 3, 3, 1}, new int[] { 1, 4, 6, 4, 1}};
            var outputB = new int[][] { new int[] { 1 } };

            Assert.AreEqual(outputA, task.Generate(5));
            Assert.AreEqual(outputB, task.Generate(1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
