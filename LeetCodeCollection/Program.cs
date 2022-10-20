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
            var outputA = "III";
            var outputB = "LVIII";
            var outputC = "MCMXCIV";

            Assert.AreEqual(outputA, task.IntToRoman(3));
            Assert.AreEqual(outputB, task.IntToRoman(58));
            Assert.AreEqual(outputC, task.IntToRoman(1994));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
