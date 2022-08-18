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
            Assert.AreEqual(2, task.MinSetSize(new[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 }));
            Assert.AreEqual(1, task.MinSetSize(new[] { 7, 7, 7, 7, 7, 7 }));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
