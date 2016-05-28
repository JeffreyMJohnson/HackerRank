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
    public class Program
    {
        
        public static bool IsDecentNumber(string testNum)
        {
            /*Its digits can only be 3's and/or 5's.
The number of 3's it contains is divisible by 5.
The number of 5's it contains is divisible by 3.
If there are more than one such number, we pick the largest one.*/
            int fiveCount = testNum.Count(c => c == '5');
            int threeCount = testNum.Count(c => c == '3');
            bool isOnlyFiveAndThree = fiveCount + threeCount == testNum.Length;
            bool numFivesDivisibleByThree = fiveCount % 3 == 0;
            bool numThreesDivisibleByFive = threeCount % 5 == 0;
            return isOnlyFiveAndThree && numThreesDivisibleByFive && numFivesDivisibleByThree;
        }

        public static string LargestDecentNumber(int numDigits)
        {
            
            int tailNum = numDigits % 15;
            string tail = ""; //hotdog
            switch (tailNum)
            {
                case 0:
                case 1:
                case 2:
                    goto case 13;
                    break;
                case 3:
                    tail = "555";
                    break;
                case 4:
                    goto case 13;
                    break;
                case 5:
                    tail = "33333";
                    break;
                case 6:
                    tail = "555555";
                    break;
                case 7:
                    goto case 13;
                    break;
                case 8:
                    tail = "55533333";
                    break;
                case 9:
                    tail = "555555555";
                    break;
                case 10:
                    tail = "3333333333";
                    break;
                case 11:
                    tail = "55555533333";
                    break;
                case 12:
                    tail = "555555555555";
                    break;
                case 13:
                    tail = "-1";
                    break;
                case 14:
                    tail = "555555555333333";
                    break;
            }

            string result = "";
            for (int i = 0; i < numDigits - tailNum; i++)
            {
                result += '5';
            }
            result += tail;

            if (IsDecentNumber(result))
            {
                return result;
            }
            else
            {
                return "-1";
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
                int testNum = int.Parse(Console.ReadLine());
                Console.WriteLine(LargestDecentNumber(testNum));
            }



        }
    }
}
