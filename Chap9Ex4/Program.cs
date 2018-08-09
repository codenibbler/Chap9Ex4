using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that finds how many times certain number can be
            // found in a given array. Write a program to test that the method works
            // correctly.

            int[] testArr = { 1, 4, 5, 5, 6, 7, 8, 9, 4, 9, 9, 9, 3 };

            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(numOccur(testArr, number));
            Console.ReadLine();


        }

        static int numOccur(int[] inputArr, int number)
        {
            int occur = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == number)
                {
                    occur++;
                }
            }

            return occur;
        }
    }
}
