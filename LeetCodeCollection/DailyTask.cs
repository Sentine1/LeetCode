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
            public IList<int> FindSubstring(string s, string[] words)
            {

                List<int> ans = new List<int>();

                if (words.Length == 0)
                    return ans;

                int n = words.Length, len = words[0].Length;
                Dictionary<string, int> expect = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    if (expect.ContainsKey(word))
                        expect[word]++;
                    else
                        expect.Add(word, 1);
                }

                Dictionary<string, int> seen = new Dictionary<string, int>();

                for (int i = 0; i < s.Length - n * len + 1; i++)
                {
                    seen.Clear();
                    int count = 0;
                    while (count < n)
                    {
                        string curr = s.Substring(i + count * len, len);

                        if (expect.ContainsKey(curr))
                        {
                            if (seen.ContainsKey(curr))
                                seen[curr]++;
                            else
                                seen.Add(curr, 1);

                            if (seen[curr] > expect[curr])
                                break;
                        }
                        else
                            break;

                        count++;
                    }

                    if (count == n)
                        ans.Add(i);
                }

                return ans;
            }
        }
    }
}
