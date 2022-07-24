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
                new int[] {1,4,7,11,15 },
                new int[] {2, 5, 8, 12, 19},
                new int[]{3, 6, 9, 16, 22},
                new int[]{10, 13, 14, 17, 24},
                new int[]{18, 21, 23, 26, 30}
            };
            var inputB = inputA;

            Assert.True(task.SearchMatrix(inputA, 5));
            Assert.False(task.SearchMatrix(inputB, 20));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
