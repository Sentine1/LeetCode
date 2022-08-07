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


            Assert.AreEqual(5, task.CountVowelPermutation(1));
            Assert.AreEqual(10, task.CountVowelPermutation(2));
            Assert.AreEqual(68, task.CountVowelPermutation(5));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
