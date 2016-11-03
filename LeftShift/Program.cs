#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankUtility;
/*
 * A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. For example, if left rotations are performed on array , then the array would become .

Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.

Input Format

The first line contains two space-separated integers denoting the respective values of  (the number of integers) and  (the number of left rotations you must perform). 
The second line contains  space-separated integers describing the respective elements of the array's initial state.
*/
namespace LeftShift
{
    class Program
    {

        static int[] LeftShift(int[] array, int shift)
        {
            int shiftIndex = shift%array.Length;
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; ++i)
            {
                result[i] = array[shiftIndex];

                ++shiftIndex;
                if (shiftIndex >= array.Length)
                {
                    shiftIndex = 0;
                }
            }
            return result;
        }

        static void PrintIt(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }


        static void Main(string[] args)
        {
#if TEST
            string[] input = TestData.Get("data/data_1.txt");
            string[] tokens = input[0].Split(' ');

            int numOfIntegers = Int32.Parse(tokens[0]);
            int numRotations = Int32.Parse(tokens[1]);
            tokens = input[1].Split(' ');

#else
            string[] tokens = Console.ReadLine().Split(' ');
            int numOfIntegers = Int32.Parse(tokens[0]);
            int numRotations = Int32.Parse(tokens[1]);
            tokens = Console.ReadLine().Split(' ');
#endif
            int[] array = Array.ConvertAll(tokens, Int32.Parse);
            int[] result = LeftShift(array, numRotations);
            PrintIt(result);
            Console.ReadKey();
        }
    }
}
