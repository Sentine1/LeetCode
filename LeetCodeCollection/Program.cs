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

            var inputA = new int[][] { 
                new int[] { 1, 3 }, 
                new int[] { 2, 2 },
                new int[]{ 3, 1 }
            };
            var inputB = new int[][] {
                new int[] { 5, 10 },
                new int[] { 2, 5 },
                new int[] { 4, 7 },
                new int[] { 3, 9 }
            };


            Assert.AreEqual(8, task.MaximumUnits(inputA, 4), "wrong answer");
            Assert.AreEqual(91, task.MaximumUnits(inputB, 10), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
