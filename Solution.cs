using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Math;

namespace LeetCodeCsharp
{
    public class Solution
    {
        public static int[] Q1TwoSum(int[] numberList, int target)
        {
            for (int i = 0; i < numberList.Length; i++)
            {
                for (int j = i + 1; j < numberList.Length; j++)
                {
                    if (numberList[j] == target - numberList[i])
                    {
                        return new int[2] { i, j };
                    }
                }
            }
        
            return null;
        }

        public static int[] Q1TwoSumDict(int[] nums, int target)
        {
            var numsDict = new Dictionary<int, int>(); // try to use dictionary for index purpose.

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsDict.ContainsKey(target - nums[i]))
                {
                    numsDict[nums[i]] = i;
                }
                else
                {
                    return new int[2] { numsDict[target - nums[i]], i};
                }
            }

            return null;
        }

        public static int Q1009BitwiseComplement(int N)
        {
            var complementInt = 0;
            var cnt = 0;

            if (N == 0) return 1;

            while (N > 0)
            {
                if (N % 2 == 0)
                {
                    complementInt += Convert.ToInt32(Pow(2, cnt));
                }
                cnt += 1;
                N /= 2;
            }

            return complementInt;
        }

        public static int Q322CoinChange(int[] coins, int amount) // TODO
        {
            Array.Sort(coins); // Sort the array in ascending
            IList<int> possibleCombination = new List<int>();


            for (int i = coins.Length; i > 0; i--)
            {
                int diffAmount = amount;
                int coinCombinationStepCount = 0; // steps of valid combination
                int[] tempCoins = coins.Take(i).ToArray(); // temp store the array for other combination search


                while (tempCoins.Length > 0 && diffAmount >= tempCoins[0])
                {
                    coinCombinationStepCount += (Int32)(diffAmount / tempCoins.Last()); // save the steps of the last element
                    diffAmount = diffAmount % tempCoins.Last(); // refresh the diff
                    tempCoins = tempCoins.Take(tempCoins.Length - 1).ToArray(); // remove the last element in the array
                }

                if (diffAmount == 0)
                {
                    possibleCombination.Add(coinCombinationStepCount);
                }
            }

            return possibleCombination.Count == 0 ? -1 : possibleCombination.Min();
        }
    }
}