﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int Fib(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}