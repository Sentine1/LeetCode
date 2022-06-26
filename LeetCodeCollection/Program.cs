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
            var inputA = new[] { 1, 2, 3, 4, 5, 6, 1 }; // к = 3
            var inputB = new[] { 2, 2, 2 }; // к = 2
            var inputC = new[] { 9, 7, 7, 9, 7, 7, 9 }; // к = 7
            
            Assert.True(task.MaxScore(inputA, 3) == 12, "wrong answer");
            Assert.True(task.MaxScore(inputB, 2) == 4, "wrong answer");
            Assert.True(task.MaxScore(inputC, 7) == 55, "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
