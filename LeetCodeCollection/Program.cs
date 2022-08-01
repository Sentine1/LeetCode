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

            Assert.AreEqual(28,task.UniquePaths(3,7));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
