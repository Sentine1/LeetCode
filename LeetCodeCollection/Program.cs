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

            var wordA = "anagram";
            var wordB = "rat";
            var wordC = "ab";
            var annagramA = "nagaram";
            var annagramB = "car";
            var annagramC = "a";

            Assert.True(task.IsAnagram(wordA, annagramA));
            Assert.False(task.IsAnagram(wordB, annagramB));
            Assert.False(task.IsAnagram(wordC, annagramC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
