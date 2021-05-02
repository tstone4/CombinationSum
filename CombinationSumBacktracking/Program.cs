using System;
using System.Collections.Generic;

namespace CombinationSumBacktracking
{
    class Program
    {
        IList<IList<int>> results = new List<IList<int>>();
        static void Main()
        {
            int[] candidates = new int[] {2,3,6,7};
            int target = 7;
            Program program = new Program();
            program.CombinationSum(candidates, target);
            foreach (List<int> item in program.results)
            {
                foreach (int subitem in item)
                {
                    Console.Write(subitem);
                }
                Console.WriteLine();
            }
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IsTargetEqualToTotal(candidates, target, 0, 0, new List<int>());
            return results;
        }
        public void IsTargetEqualToTotal(int[] candidates, int target, int index, int total, List<int> combinationToGetHere)
        {
            if(total > target)
            {
                return;
            }
            if(total == target)
            {
                results.Add(new List<int>(combinationToGetHere));
            }

            for(int i = index; i < candidates.Length; i++)
            {
                combinationToGetHere.Add(candidates[i]);
                IsTargetEqualToTotal(candidates, target, i, total + candidates[i], combinationToGetHere);
                combinationToGetHere.RemoveAt(combinationToGetHere.Count - 1);
            }

            return;
        }
    }
}
