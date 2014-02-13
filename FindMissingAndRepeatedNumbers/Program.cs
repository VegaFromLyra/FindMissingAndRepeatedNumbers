using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an unsorted array of size n. Array elements are in range from 1 to n. 
// Numbers from set {1, 2, …n} could be missing or/and could be repeated. 
// Find the missing and repeated numbers in O(n) time and O(n) space.
namespace FindMissingAndRepeatedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 1, 1, 2, 2 };
            PrintMissingAndRepeatedNumbers(input);
        }


        // Traverse the array. While traversing, use absolute value
        // of every element as index and make the value at this index as
        // negative to mark it visited. If something is already marked 
        // negative then this is the repeating element. To find missing,
        // traverse the array again and look for a positive value
        static void PrintMissingAndRepeatedNumbers(int[] input)
        {
            Console.WriteLine("Repeated numbers");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[Math.Abs(input[i]) - 1] < 0)
                {
                    Console.Write(Math.Abs(input[i]) + " ");
                }
                else
                {
                    input[Math.Abs(input[i]) - 1] = -input[Math.Abs(input[i]) - 1];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Missing numbers");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    Console.Write(i + 1 + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
