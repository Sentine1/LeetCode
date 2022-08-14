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
            public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
            {
                Func<string, List<Problem>> generateNewWords;
                if (wordList.Count < 26 * beginWord.Length)
                {
                    //Let W be word length, L be wordList count。
                    //If wordList is short, iterate wordList。
                    //Iteration count is L, the complexity of IsDifference1 is W, so overall complexity is  O(WL).
                    var enhancedList = wordList.Select(w => new Problem(w)).ToList();
                    var words = new List<Problem>(enhancedList);
                    generateNewWords = begingWord => (from w in words
                                                      where IsDifference1(w.Word, begingWord)
                                                      select w).ToList();

                }
                else
                {
                    //If wordList is long, iterate and change the char in the starting word, then check if the new word is in wordList.
                    //Iteration count is 26W, the complexity of IsDifference1 is W, so overall complexity is O(26W^2) -> O(W^2).
                    var dic = wordList.ToHashSet();
                    generateNewWords = word =>
                    {
                        List<Problem> list = new List<Problem>();
                        var charArr = word.ToCharArray();
                        for (int j = 0; j < charArr.Length; j++)
                        {
                            char ch = charArr[j];
                            for (int k = 0; k < 26; k++)
                            {
                                char nextCh = (char)(k + 'a');
                                if (nextCh == ch)
                                    continue;

                                charArr[j] = nextCh;
                                string nextWord = new string(charArr);
                                if (dic.Contains(nextWord) && IsDifference1(nextWord, word))
                                    list.Add(new Problem(nextWord));
                            }
                            charArr[j] = ch;
                        }
                        return list;
                    };
                }
                //Up to here, the complexity of generateNewWords is O(min(WL,W^2)).
                var transforms = FindLadders(new Problem(beginWord), endWord, generateNewWords, wordList.Count);
                //If there is no solution, return empty list as required.
                if (transforms.Count == 0)
                    return new List<IList<string>>();
                else
                {
                    var result = (from t in transforms
                                  select (IList<string>)t.ToList()).ToList();
                    Debug.Assert(result.All(t => t[t.Count - 1] == endWord), "The last element must be endWord。");
                    Debug.Assert(result.All(t => t[0] == beginWord), "The first element must be beginWord。");
                    return result;
                }
            }

            /// <summary>
            /// </summary>
            /// <returns></returns>
            /// <remarks>
            /// Let the complexity of generateNewWords be g
            /// in the worst case there are L^L nodes, each node needs to check if it's the solution, which is O(W), then expand the node, which is O(min(WL,W^2)). 
            /// Therefore, overall complexity is O((W+g)L^L).
            /// </remarks>
            List<LinkedList<string>> FindLadders(Problem beginWord, string endWord, Func<string, List<Problem>> generateNewWords, int wordListCount)
            {
                //Can transform beginWord how many times
                int usedTransformLimit = wordListCount;
                Debug.Assert(usedTransformLimit >= 0);
                var queue = new Queue<Problem>();
                queue.Enqueue(beginWord);
                List<LinkedList<string>> shortestTransformations = new List<LinkedList<string>>();
                var expansionMap = new Dictionary<string, Tuple<int, IList<Problem>>>(wordListCount - 1 + 1);//-1 means to remove endWord, +1 means to add beginWord
                while (queue.Count > 0)
                {
                    var problem = queue.Dequeue();
                    if (problem.Word == endWord)
                    {
                        var transform = ChainTransform(problem);
                        Debug.Assert(shortestTransformations.Count == 0 || transform.Count == shortestTransformations[0].Count);
                        shortestTransformations.Add(transform);

                        Debug.Assert(problem.UsedTransform <= usedTransformLimit);
                        usedTransformLimit = problem.UsedTransform;
                    }

                    Debug.Assert(problem.UsedTransform <= usedTransformLimit);
                    if (problem.UsedTransform == usedTransformLimit)
                        continue;

                    if (expansionMap.TryGetValue(problem.Word, out var nextWords) == false || nextWords.Item2 == null) //(b)
                    {
                        nextWords = new Tuple<int, IList<Problem>>(nextWords?.Item1 ?? problem.UsedTransform + 1, generateNewWords(problem.Word));
                        expansionMap[problem.Word] = nextWords;
                    }

                    foreach (var w in nextWords.Item2)
                    {
                        var p = new Problem(w.Word, problem);
                        if (expansionMap.TryGetValue(p.Word, out var v) == false || v.Item1 >= p.UsedTransform) //(a)
                        {
                            queue.Enqueue(p);
                            expansionMap[p.Word] = new Tuple<int, IList<Problem>>(p.UsedTransform, v?.Item2);
                        }
                    }
                }
                return shortestTransformations;
            }

            bool IsDifference1(string w1, string w2)
            {
                Debug.Assert(w1.Length == w2.Length);

                bool hasDifference = false;
                for (int i = 0; i < w1.Length; i++)
                {
                    if (w1[i] != w2[i])
                    {
                        if (hasDifference)
                            return false;
                        else
                            hasDifference = true;
                    }
                }

                return hasDifference;
            }

            LinkedList<string> ChainTransform(Problem p)
            {
                var list = new LinkedList<string>();
                while (p != null)
                {
                    list.AddFirst(p.Word);
                    p = p.Parent;
                }

                return list;
            }

            //[DebuggerDisplay("Word={Word}, d={DifferenceFromSolution}")]
            class Problem
            {
                public Problem(string word, Problem parent = null)
                {
                    Word = word;
                    Parent = parent;
                    if (parent != null)
                        UsedTransform = parent.UsedTransform + 1;
                }
                public string Word { get; }

                /// <summary>
                /// Transforms used since the beginning
                /// </summary>
                public int UsedTransform { get; }

                public Problem Parent { get; }
            }
        }
    }
}
