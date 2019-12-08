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
            // Q1: Two Sum
            var indices = Solution.TwoSumDict(new[] { 2, 10, 7, 11, 9 }, 9);
            Console.WriteLine("Result of TwoSum is: [{0}, {1}]", indices[0], indices[1]);

            Console.ReadKey();
        }
    }
}
