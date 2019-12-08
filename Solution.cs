using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeCsharp
{
    public class Solution
    {
        public static int[] TwoSum(int[] numberList, int target)
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

        public static int[] TwoSumDict(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    return new int[] { dict[target - nums[i]], i };
                dict[nums[i]] = i;
            }

            return null;
        }
    }
}