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
            var mySolution = new Solution();
            var indices = mySolution.TwoSum(new[] { 2, 10, 7, 11, 9 }, 9);
            try
            {
                Console.WriteLine("Result of TwoSum is: [{0}, {1}]", indices[0], indices[1]);
            }
            catch
            {
                Console.WriteLine("No two sum match for target.");
            }

            Console.ReadKey();
        }
    }
}
