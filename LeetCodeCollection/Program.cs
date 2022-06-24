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
            var inputA = new[] { 9, 3, 5 };
            var inputB = new[] { 1, 1, 1, 2 };
            var inputC = new[] { 8, 5 };
            
            Assert.True(task.IsPossible(inputA), "wrong answer");
            Assert.True(task.IsPossible(inputB) == false, "wrong answer");
            Assert.True(task.IsPossible(inputC), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
