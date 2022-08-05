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
            var inputA = new[] { 1, 2, 3};
            var inputB = new[] { 9} ;

            Assert.AreEqual(7, task.CombinationSum4(inputA, 4));
            Assert.AreEqual(0, task.CombinationSum4(inputB, 3));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
