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
            var inputA = new[] { new[] { 5, 5 }, new[] { 6, 3 }, new[] { 3, 6 } };
            var inputB = new[] { new[] { 2, 2 }, new[] { 3, 3 } };
            var inputC = new[] { new[] { 1, 5 }, new[] { 10, 4 }, new[] { 4, 3 } };
            var inputD = new[] { 
                new[] { 7, 9 }, new[] { 10, 7 }, new[] { 6, 9 }, 
                new[] { 10, 4 }, new[] { 7, 5 }, new[] { 7, 10 } };

            Assert.AreEqual(0, task.NumberOfWeakCharacters(inputA));
            Assert.AreEqual(1, task.NumberOfWeakCharacters(inputB));
            Assert.AreEqual(1, task.NumberOfWeakCharacters(inputC));
            Assert.AreEqual(2, task.NumberOfWeakCharacters(inputD));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
