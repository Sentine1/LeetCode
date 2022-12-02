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

            var inputA = ("abc","bca");
            var inputB = ("a", "aa");
            var inputC = ("cabbba", "abbccc");
            var inputD = ("cabbba", "aabbss");

            Assert.AreEqual(true, task.CloseStrings(inputA.Item1,inputA.Item2));
            Assert.AreEqual(false, task.CloseStrings(inputB.Item1, inputB.Item2));
            Assert.AreEqual(true, task.CloseStrings(inputC.Item1, inputC.Item2));
            Assert.AreEqual(false, task.CloseStrings(inputD.Item1, inputD.Item2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
