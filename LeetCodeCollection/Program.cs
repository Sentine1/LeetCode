using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new DailyTask.MyCalendar();

            Assert.Null(task.Book());
            Assert.True(task.Book(10, 20));
            Assert.False(task.Book(15, 25));
            Assert.True(task.Book(20, 30));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
