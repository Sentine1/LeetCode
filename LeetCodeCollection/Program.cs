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
            var inputA = 1;
            var inputB = 3;
            var inputС = 12;
            var outputA = 1;
            var outputB = 27;
            var outputС = 505379714;

            Assert.AreEqual(outputA, task.ConcatenatedBinary(inputA));
            Assert.AreEqual(outputB, task.ConcatenatedBinary(inputB));
            Assert.AreEqual(outputС, task.ConcatenatedBinary(inputС));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
