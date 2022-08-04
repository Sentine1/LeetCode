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

            Assert.AreEqual(2, task.MirrorReflection(2, 1));
            Assert.AreEqual(1, task.MirrorReflection(3, 1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
