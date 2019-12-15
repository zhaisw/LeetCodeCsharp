using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Two Sum - Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            var indices = Solution.Q1TwoSumDict(new[] { 2, 10, 17, 7, 9 }, 9);
            Console.WriteLine("Result of TwoSum is: [{0}, {1}]", indices[0], indices[1]);

            // Q1009: Complement of Base 10 Integer
            Console.WriteLine("Complement of int {0} is: {1}", 10, Solution.Q1009BitwiseComplement(10));

            // Q322: Coin change
            var dict = new Dictionary<string, decimal>();

//            dict.Add("A", 1.5m); // This value will be skipped
//            dict.Add("B", 2.7m);
//            dict.Add("C", 1.3m);
//            dict.Add("D", 3.9m);

            var total = dict.Skip(0).Sum(v => v.Value);

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
