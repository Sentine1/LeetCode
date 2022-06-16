using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "babad";
            var b = "cbbd";
            var dailyTask = new DailyTask.Solution();
            Assert.IsTrue(dailyTask.LongestPalindrome(
                a) == "bab" || dailyTask.LongestPalindrome(
                a) == "aba");
            Assert.IsTrue(dailyTask.LongestPalindrome(
                b) == "bb");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
