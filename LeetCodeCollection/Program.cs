using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var daily = new DailyTask.Solution();
            var productA = new[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            var outputA = new List<List<string>> {
                new List<string> {"mobile", "moneypot", "monitor" },
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" }
            };
            var productB = new[] { "havana" };
            var outputB = new List<List<string>> {
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" }
            };
            var productC = new[] { "bags", "baggage", "banner", "box", "cloths" };
            var outputC = new List<List<string>> {
                new List<string> { "baggage","bags","banner" },
                new List<string> { "baggage","bags","banner" },
                new List<string> { "baggage","bags" },
                new List<string> { "bags" }
            };
            CollectionAssert.AreEqual(daily.SuggestedProducts(productA, "mouse"), outputA, "Error wrong answer");
            CollectionAssert.AreEqual(daily.SuggestedProducts(productB, "havana"), outputB, "Error wrong answer");
            CollectionAssert.AreEqual(daily.SuggestedProducts(productC, "bags"), outputC, "Error wrong answer");
            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
