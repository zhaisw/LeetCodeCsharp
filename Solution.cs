namespace LeetCodeCsharp
{
    public class Solution
    {
        public int[] TwoSum(int[] numberList, int target)
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

            return new int[] { };
        }
    }
}