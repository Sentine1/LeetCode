using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new DailyTask.Solution.NumArray(new[] { 1, 3, 5 });


            task.SumRange( 0, 2 );
            task.Update(1, 2);
            task.SumRange(0, 2);
            var output = new int?[] { null, 9, null, 8 };

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
