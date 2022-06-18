using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var daily = new DailyTask.WordFilter(new []{ "apple" });
            Assert.IsTrue(daily.f("a","e")==0,$"{daily.f("a","e")} must be 0");
            daily = new DailyTask.WordFilter(new[] { "WordFilter" });
            Assert.IsTrue(daily.f("a", "e") == -1, $"{daily.f("a", "e")} must be -1");
            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
