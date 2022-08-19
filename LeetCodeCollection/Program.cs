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
            Assert.True(task.IsPossible(new[] { 1, 2, 3, 3, 4, 5 }));
            Assert.True(task.IsPossible(new[] { 1, 2, 3, 3, 4, 4, 5, 5 }));
            Assert.False(task.IsPossible(new[] { 1, 2, 3, 4, 4, 5 }));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
