using System;
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
            public IList<string> WordSubsets(string[] inputWords, string[] dictionary)
            {
                if (inputWords == null || dictionary == null || inputWords.Length == 0 || dictionary.Length == 0)
                    return new List<string>();

                var maxCountOfB = getMaximumCount(dictionary);
                var wordsFound = new List<string>();

                foreach (var word in inputWords)
                {
                    var current = new int[26];
                    foreach (var item in word)
                    {
                        current[item - 'a']++;
                    }

                    var findException = false;
                    for (int i = 0; i < 26; i++)
                    {
                        if (current[i] < maxCountOfB[i])
                        {
                            findException = true;
                            break;
                        }
                    }

                    if (findException)
                        continue;

                    wordsFound.Add(word);
                }

                return wordsFound;
            }

            private static int[] getMaximumCount(string[] words)
            {
                var maxCount = new int[26];

                foreach (var word in words)
                {
                    var current = new int[26];
                    foreach (var item in word)
                    {
                        current[item - 'a']++;
                    }

                    for (int i = 0; i < 26; i++)
                    {
                        if (current[i] > maxCount[i])
                            maxCount[i] = current[i];
                    }
                }

                return maxCount;
            }
        }
    }
}