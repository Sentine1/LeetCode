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
            var inputA = "barfoothefoobarman";
            var inputB = "wordgoodgoodgoodbestword";
            var inputC = "barfoofoobarthefoobarman";
            var InputAA = new string[] { "foo", "bar" };
            var InputBB = new string[] { "word", "good", "best", "word" };
            var inputCC = new string[] { "bar", "foo", "the" };
            Assert.AreEqual(new int[] { 0, 9 }, task.FindSubstring(inputA, InputAA));
            Assert.AreEqual(new int[] { }, task.FindSubstring(inputB, InputBB));
            Assert.AreEqual(new int[] { 6, 9, 12 }, task.FindSubstring(inputC, inputCC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
