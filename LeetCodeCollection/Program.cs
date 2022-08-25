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

            Assert.True(task.CanConstruct("aaab","baaa"));
            Assert.False(task.CanConstruct("a","b"));
            Assert.True(task.CanConstruct("aa","aab"));
            Assert.False(task.CanConstruct("ba","b"));
            Assert.False(task.CanConstruct("aa","ab"));
            Assert.True(task.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
