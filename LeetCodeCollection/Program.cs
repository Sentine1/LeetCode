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
            var inputA = "aab";
            var inputB = "aaabbbcc";
            var inputC = "ceabaacb";

            Assert.True(task.MinDeletions(inputA) == 0, "wrong answer");
            Assert.True(task.MinDeletions(inputB) == 2, "wrong answer");
            Assert.True(task.MinDeletions(inputC) == 2, "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
