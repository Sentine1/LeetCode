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
            var inputA = "Let's take LeetCode contest";
            var inputB = "God Ding";
            var outputA = "s'teL ekat edoCteeL tsetnoc";
            var outputB = "doG gniD";

            Assert.AreEqual(outputA, task.ReverseWords(inputA));
            Assert.AreEqual(outputB, task.ReverseWords(inputB));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
