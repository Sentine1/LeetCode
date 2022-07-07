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

            var inputA = ("aabcc", "dbbca", "aadbbcbcac");
            var inputB = ("aabcc", "dbbca", "aadbbbaccc");
            var inputC = ("", "", "");

            Assert.True(task.IsInterleave(inputA.Item1, inputA.Item2, inputA.Item3), "wrong answer");
            Assert.True(!task.IsInterleave(inputB.Item1, inputB.Item2, inputB.Item3), "wrong answer");
            Assert.True(task.IsInterleave(inputC.Item1, inputC.Item2, inputC.Item3), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
