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
            Assert.AreEqual(3, task.RomanToInt("III"));
            Assert.AreEqual(58, task.RomanToInt("LVIII"));
            Assert.AreEqual(1994, task.RomanToInt("MCMXCIV"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
