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

            var inputA = new int[] { 1, 1, 2, 2, 2 };
            var inputB = new int[] { 3, 3, 3, 3, 4 };

            Assert.True(task.Makesquare(inputA));
            Assert.False(task.Makesquare(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
