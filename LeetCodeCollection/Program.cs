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
            var inputA = new[] { 100,  };
            var inputB = new[] { 100, 200 };
            var inputC = new[] { 100, 200, 300, 400 };

            Assert.AreEqual(0, task.BagOfTokensScore(inputA, 50));
            Assert.AreEqual(1, task.BagOfTokensScore(inputB, 100));
            Assert.AreEqual(2, task.BagOfTokensScore(inputC, 200));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
