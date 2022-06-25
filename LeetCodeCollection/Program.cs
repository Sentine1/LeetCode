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
            var inputA = new[] { 4, 2, 3 };
            var inputB = new[] { 4, 2, 1 };
            var inputC = new[] { 3, 4, 2, 3 };
            var inputD = new[] { -1, 4, 2, 3 };
            
            Assert.True(task.CheckPossibility(inputA), "wrong answer");
            Assert.True(task.CheckPossibility(inputB) == false, "wrong answer");
            Assert.True(task.CheckPossibility(inputC) == false, "wrong answer");
            Assert.True(task.CheckPossibility(inputD), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey()
                ;
        }
    }
}
