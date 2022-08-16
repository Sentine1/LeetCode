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
            Assert.AreEqual(0, task.FirstUniqChar("leetcode"));
            Assert.AreEqual(2, task.FirstUniqChar("loveleetcode"));
            Assert.AreEqual(-1, task.FirstUniqChar("aabb"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
