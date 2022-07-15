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
                new[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new[] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 } 
            };
            var inputB = new int[][] {new[] { 0, 0, 0, 0, 0, 0, 0, 0 } };

            Assert.AreEqual(6, task.MaxAreaOfIsland(inputA));
            Assert.AreEqual(0, task.MaxAreaOfIsland(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
