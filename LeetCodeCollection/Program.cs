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
            var inputA = "32";
            var inputB = "82734";
            var inputC = "27346209830709182346";

            Assert.True(task.MinPartitions(inputA) == 3, "wrong answer");
            Assert.True(task.MinPartitions(inputB) == 8, "wrong answer");
            Assert.True(task.MinPartitions(inputC) == 9, "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
