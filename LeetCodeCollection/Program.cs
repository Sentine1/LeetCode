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

            var inputA = new[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            var inputB = new[] { "a", "b", "c" };
            var outputA = new[] { "mee","aqq" };
            var outputB = new[] { "a", "b", "c" };

            Assert.AreEqual(outputA,task.FindAndReplacePattern(inputA, "abb"));
            Assert.AreEqual(outputB,task.FindAndReplacePattern(inputB, "a"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
