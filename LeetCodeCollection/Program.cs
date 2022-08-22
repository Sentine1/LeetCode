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

            Assert.True(task.IsPowerOfFour(16));
            Assert.False(task.IsPowerOfFour(5));
            Assert.True(task.IsPowerOfFour(1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
