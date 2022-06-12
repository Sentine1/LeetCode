using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCollection.Tasks11_20
{
    class Task17_Meeting_Rooms
    {
        public class Interval
        {
            public int start, end;
            Interval(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }

        public bool CanAttendMeetings(List<Interval> intervals)
        {
            intervals = intervals.OrderBy(x=>x.start).ToList();
            var priveous = int.MinValue;
            foreach (var element in intervals)
            {
                if (priveous > element.start)
                    return false;
                priveous = element.end;
            }
            return true;
        }
    }
}
