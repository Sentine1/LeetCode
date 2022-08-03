using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class MyCalendar
        {
            List<int[]> calendar;

            public MyCalendar()
            {
                calendar = new();
            }

            public bool Book(int start, int end)
            {
                foreach (var book in calendar)
                    if (Math.Max(book[0], start) < Math.Min(book[1], end))
                        return false;
                calendar.Add(new int[] { start, end });
                return true;
            }
            public string Book()
            {
                return null;
            }
        }
    }
}