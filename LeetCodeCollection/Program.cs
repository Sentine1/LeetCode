using System;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 3, 2, 20, 1, 1, 3 };
            var task = new BigInput.Solution();
            Console.WriteLine(task.MinOperations(array,10));
            Console.ReadKey();
        }
    }
}
