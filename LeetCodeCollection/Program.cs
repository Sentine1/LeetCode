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

            var inputA = "the sky is blue";
            var inputB = "  hello world  ";
            var inputC = "a good   example";

            var ouputA = "blue is sky the";
            var ouputB = "world hello";
            var ouputC = "example good a";

            Assert.AreEqual(ouputA, task.ReverseWords(inputA));
            Assert.AreEqual(ouputB, task.ReverseWords(inputB));
            Assert.AreEqual(ouputC, task.ReverseWords(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
