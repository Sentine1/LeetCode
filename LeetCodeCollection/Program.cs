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
            var inputA = "thequickbrownfoxjumpsoverthelazydog";
            var inputB = "leetcode";

            Assert.AreEqual(true, task.CheckIfPangram(inputA));
            Assert.AreEqual(false, task.CheckIfPangram(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
