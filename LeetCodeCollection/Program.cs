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

            Assert.True(task.IsPowerOfThree(27));
            Assert.False(task.IsPowerOfThree(0));
            Assert.True(task.IsPowerOfThree(9));
            Assert.True(task.IsPowerOfThree(243));
            Assert.False(task.IsPowerOfThree(19682));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
