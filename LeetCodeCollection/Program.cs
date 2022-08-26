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

            Assert.True(task.ReorderedPowerOf2(1));
            Assert.False(task.ReorderedPowerOf2(10));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
