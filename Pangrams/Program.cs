#define TESTING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankUtility;
using Microsoft.SqlServer.Server;

/*
 Roy wanted to increase his typing speed for programming contests. So, his friend advised him to type the sentence "The quick brown fox jumps over the lazy dog" repeatedly, because it is a pangram. (Pangrams are sentences constructed by using every letter of the alphabet at least once.)

After typing the sentence several times, Roy became bored with it. So he started to look for other pangrams.

Given a sentence , tell Roy if it is a pangram or not.

Input Format

Input consists of a string .

Constraints 
Length of  can be at most   and it may contain spaces, lower case and upper case letters. Lower-case and upper-case instances of a letter are considered the same.

Output Format

Output a line containing pangram if  is a pangram, otherwise output not pangram.
*/

namespace Pangrams
{
    class Program
    {
        static bool IsPangram(string s)
        {
            string lower = s.ToLower();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                if (!lower.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            string result;
            if (IsPangram(test))
            {
                result = "is a pangram";
            }
            else
            {
                result = "no pangram";
            }
            Console.WriteLine(result);
        }
    }
}
