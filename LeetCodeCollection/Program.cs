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

            var outputA = ("abcde", new string[] { "a", "bb", "acd", "ace" });
            var outputB = ("dsahjpjauf", new string[] { "ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax" });

            Assert.AreEqual(3, task.NumMatchingSubseq(outputA.Item1, outputA.Item2));
            Assert.AreEqual(2, task.NumMatchingSubseq(outputB.Item1, outputB.Item2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
