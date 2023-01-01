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
            var InputA = ("abba", "dog cat cat dog");
            var InputB = ("abba", "dog cat cat fish");
            var InputC = ("aaaa", "dog cat cat dog");
            var InputD = ("abba", "dog dog dog dog");

            Assert.True(task.WordPattern(InputA.Item1,InputA.Item2));
            Assert.False(task.WordPattern(InputB.Item1, InputB.Item2));
            Assert.False(task.WordPattern(InputC.Item1, InputC.Item2));
            Assert.False(task.WordPattern(InputD.Item1, InputD.Item2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
