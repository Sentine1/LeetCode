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
            var outputA = new int[] { 181, 292, 707, 818, 929 };
            var outputB = new int[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 };

            Assert.AreEqual(outputA, task.NumsSameConsecDiff(3, 7));
            Assert.AreEqual(outputB, task.NumsSameConsecDiff(2, 1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
