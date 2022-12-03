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

            Assert.AreEqual("eert", task.FrequencySort("tree"));
            Assert.AreEqual("aaaccc", task.FrequencySort("cccaaa"));
            Assert.AreEqual("bbAa", task.FrequencySort("Aabb"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
