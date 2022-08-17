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
            Assert.AreEqual(2, task.UniqueMorseRepresentations(new[] { "gin", "zen", "gig", "msg" }));
            Assert.AreEqual(1, task.UniqueMorseRepresentations(new[] { "a"}));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
