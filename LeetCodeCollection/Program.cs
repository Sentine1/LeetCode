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
            var InputA = "USA";
            var InputB = "leetcode";
            var InputC = "Google";
            var InputD = "FlaG";
            var InputE = "mL";

            Assert.True(task.DetectCapitalUse(InputA));
            Assert.True(task.DetectCapitalUse(InputB));
            Assert.True(task.DetectCapitalUse(InputC));
            Assert.False(task.DetectCapitalUse(InputD));
            Assert.False(task.DetectCapitalUse(InputE));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
