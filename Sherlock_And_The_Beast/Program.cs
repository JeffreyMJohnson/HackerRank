using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * find the largest Decent Number having N digits.
 * 
 * A Decent Number has the following properties:

Its digits can only be 3's and/or 5's.
The number of 3's it contains is divisible by 5.
The number of 5's it contains is divisible by 3.
If there are more than one such number, we pick the largest one.

    Constraints
    1 <= T <= 20
    1 <= N <= 100000

    Input Format

The first line is an integer, T, denoting the number of test cases.

The T subsequent lines each contain an integer, N, detailing the number of digits in the number.

Output Format

Print the largest Decent Number having N digits; if no such number exists, tell Sherlock by printing -1.

 */
namespace Sherlock_And_The_Beast
{
    class Program
    {
        private static string[] _sampleInput =
        {
            "4",
            "1",
            "3",
            "5",
            "11"
        };

        static bool IsDecentNumber(Int64 testNum)
        {
            /*Its digits can only be 3's and/or 5's.
The number of 3's it contains is divisible by 5.
The number of 5's it contains is divisible by 3.
If there are more than one such number, we pick the largest one.*/
            string testNumString = testNum.ToString();
            int fiveCount = testNumString.Count(c => c == '5');
            int threeCount = testNumString.Count(c => c == '3');
            bool isOnlyFiveAndThree = fiveCount + threeCount == testNumString.Length;
            bool numFivesDivisibleByThree = fiveCount % 3 == 0;
            bool numThreesDivisibleByFive = threeCount % 5 == 0;
            return isOnlyFiveAndThree && numThreesDivisibleByFive && numFivesDivisibleByThree;
        }

        static string IncrementNum(string numAsString)
        {
            /*
                * Start at the LSB (least significant bit, i.e. right most bit); 
                * while the current bit is 1, change it to 0 and move left, stopping when we reach far left or hit a 0 bit, which we change to 1 and stop
                */
            string numString = numAsString;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                if (numString[i] == '3')
                {
                    char[] c = numString.ToCharArray();
                    c[i] = '5';
                    numString = new string(c);
                    break;
                }
                if (i > 0)
                {
                    char[] c = numString.ToCharArray();
                    c[i] = '3';
                    numString = new string(c);
                }

            }
            return numString;
        }

        static string FilledString(char fillChar, Int64 numDigits)
        {
            string result = "";
            for (Int64 i = 0; i < numDigits; i++)
            {
                result += fillChar;
            }
            return result;
        }

        static Int64 LargestDecentNumber(Int64 numDigits)
        {
            /*
             * create string of '3' length of given numDigits
             * 
             * while string num is not string of all '5'
             *  if string num is a decent number 
             *      add to list
             *  increment string num
             * if string num is a decent number
             *  add to list
             *  
             *  
             */


            string numString = FilledString('3', numDigits);
            string testString = FilledString('5', numDigits);
            List<Int64> decentNumbers = new List<Int64>();
            do
            {
                Int64 num = Int64.Parse(numString);
                if (IsDecentNumber(num))
                {
                    decentNumbers.Add(num);
                }
                numString = IncrementNum(numString);

            } while (numString != testString);
           


            if (IsDecentNumber(Int64.Parse(numString)))
            {
                decentNumbers.Add(Int64.Parse(numString));
            }
            if (decentNumbers.Count > 1)
            {
                Int64 num = 0;
                foreach (Int64 decentNumber in decentNumbers)
                {
                    num = Math.Max(num, decentNumber);
                }
                return num;
            }
            else if (decentNumbers.Count > 0)
            {
                return decentNumbers[0];
            }
            else
            {
                return -1;
            }




        }



        static void Main(string[] args)
        {
            /*The first line is an integer, T, denoting the number of test cases.

The T subsequent lines each contain an integer, N, detailing the number of digits in the number.
*/
            int numTests = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numTests; i++)
            {
                Int64 testNum = Int64.Parse(Console.ReadLine());
                Console.WriteLine(LargestDecentNumber(testNum));
            }



        }
    }
}
