#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HackerRankUtility;
/*
test a string for being a palindrome...
palindrome = same chars forward and backward

0110 - true
0101 - false

fcwnnwcwf

loop from 0 to length => forwardIndex
loop from length to 0 => reverseIndex
    if string[forwardIndex] != string[reverseIndex]
        if string [forwardIndex + 1] = string[reverseIndex] and string[reverseIndex - 1] != string[forwardIndex]
            return forwardIndex
        else 
            return reverseIndex
end loop
is a palendrome return -1
*/

namespace PalindromeIndex
{
    class Program
    {
        static bool IsPalindrome(string s)
        {
            for (int forward = 0, reverse = s.Length - 1; forward <= (int)(s.Length * .5); ++forward, --reverse)
            {
                if (s[forward] != s[reverse])
                {
                    return false;
                }
            }
            return true;
        }

        static int IndexToRemove(string s)
        {
            for (int forward = 0, reverse = s.Length - 1; forward <= (int)(s.Length * .5); ++forward, --reverse)
            {
                if (s[forward] != s[reverse])
                {
                    //see if palindrome without forward
                    string withoutForward = s.Substring(0, forward) + s.Substring(forward + 1);
                    if (IsPalindrome(withoutForward))
                    {
                        return forward;
                    }
                    else
                    {
                        return reverse;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int testCount = 0;
#if TEST
            string[] input = TestData.Get("data/data_12.txt");
            //string[] input = TestData.Get("data/data1.txt");
            testCount = Int32.Parse(input[0]);
#else
            testCount = Int32.Parse(Console.ReadLine());
#endif
            for (int testNum = 1; testNum <= testCount; ++testNum)
            {
                string test = "";
#if TEST
                test = input[testNum];
#else
                test = Console.ReadLine();
#endif
                int result = IndexToRemove(test);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
