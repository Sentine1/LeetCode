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
            var inputA = new[] { new[] { 1, 0, 1 }, new[] { 0, -2, 3 } };
            var inputB = new[] {new[] { 2, 2, -1 } };

            Assert.AreEqual(2, task.MaxSumSubmatrix(inputA,2));
            Assert.AreEqual(3, task.MaxSumSubmatrix(inputB,3));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
