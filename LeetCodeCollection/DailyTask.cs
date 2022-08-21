using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int[] MovesToStamp(string stamp, string target)
            {
                //edge cases
                if (stamp.Length > target.Length) return new int[] { };

                if (stamp.Length == target.Length)
                {
                    if (stamp == target) return new int[] { 0 };
                    return new int[] { };
                }

                //seems like we have got to find part of target that matches stamp
                //then we can replace those with ???? in target
                //and find a match again - but ?? in target matches anything in stamp
                //until either we can't do it (not possible), or target is all ??

                //keep track as we go and reverse it for the answer
                string newTarget = "".PadLeft(target.Length, '?');
                List<int> substitutions = new List<int>();

                while (target != newTarget)
                {
                    int index = FindMatch(stamp, target);
                    if (index == -1) return new int[] { };

                    target =
                        (index > 0 ? target.Substring(0, index) : "") +
                        "".PadLeft(stamp.Length, '?') +
                        (index < target.Length - stamp.Length ? target.Substring(index + stamp.Length) : "");

                    substitutions.Add(index);

                    //Console.WriteLine("index " + index + ", target " + target);
                }

                int[] result = substitutions.ToArray();
                Array.Reverse(result);
                return result;
            }

            public int FindMatch(string stamp, string target)
            {
                for (int i = 0; i <= target.Length - stamp.Length; i++)
                {
                    if (target.Substring(i, stamp.Length) == "".PadLeft(stamp.Length, '?')) continue;

                    bool match = true;

                    for (int j = 0; j < stamp.Length; j++)
                    {
                        if (stamp[j] != target[i + j]
                            && target[i + j] != '?')
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match) return i;
                }

                return -1;
            }
        }
    }
}
