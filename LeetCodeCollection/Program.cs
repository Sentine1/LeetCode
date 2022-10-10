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
            var defTree = new TreeNode();
            var inputA = "abccba";
            var inputB = "a";

            Assert.AreEqual("aaccba", task.BreakPalindrome(inputA));
            Assert.AreEqual("", task.BreakPalindrome(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
