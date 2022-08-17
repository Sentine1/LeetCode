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
            /// <summary>
            /// abc in morze =
            /// ".-","-...","-.-.","-..",".",
            /// "..-.","--.","....","..",".---",
            /// "-.-",".-..","--","-.","---",
            /// ".--.","--.-",".-.","...","-",
            /// "..-","...-",".--","-..-","-.--","--.."
            /// </summary>
            /// <param name="s"></param>
            /// <returns>string to morze code</returns>

            public int UniqueMorseRepresentations(string[] words)
            {
                var hash = new HashSet<string>();
                foreach (var word in words)
                {
                    var morzecode = "";
                    foreach (var ch in word)
                    {
                        morzecode += Morze[ch.ToString()];
                    }
                    if (hash.Contains(morzecode))
                        continue;
                    else hash.Add(morzecode);
                }
                
                return hash.Count;
            }

            public static readonly Dictionary<string, string> Morze =
                new Dictionary<string, string>()
                {
                    {"a",".-" },{"b","-..." },{"c","-.-." },{"d","-.." },
                    {"e","." },{"f","..-." },{"g","--." },{"h","...." },
                    {"i",".." },{"j",".---" },{"k","-.-" },{"l",".-.." },
                    {"m","--" },{"n","-." },{"o","---" },{"p",".--." },
                    {"q","--.-" },{"r",".-." },{"s","..." },{"t","-" },
                    {"u","..-" },{"v","...-" },{"w",".--" },{"x","-..-" },
                    {"y","-.--" },{"z","--.."}
            
                };
        }
    }
}
