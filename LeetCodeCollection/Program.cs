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


            Assert.AreEqual(5, task.PoorPigs(1000, 15, 60));
            Assert.AreEqual(2, task.PoorPigs(4, 15, 15));
            Assert.AreEqual(2, task.PoorPigs(4, 15, 30));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
