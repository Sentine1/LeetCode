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

            var inputA = new[] {
                new[] {'1', '1', '1', '1', '0'},
                new[] { '1', '1', '0', '1', '0'},
                new[] { '1', '1', '0', '0', '0'},
                new[]  { '0', '0', '0', '0', '0'}
            };

            var inputB = new[] {
                new [] {'1', '1', '0', '0', '0'},
                new [] {'1', '1', '0', '0', '0'},
                new [] { '0', '0', '1', '0', '0'},
                new [] { '0', '0', '0', '1', '1'}
            };

            Assert.AreEqual(1, task.NumIslands(inputA));
            Assert.AreEqual(3, task.NumIslands(inputB));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
