using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        /*
         Alice wrote a sequence of words in CamelCase as a string of letters, , having the following properties:

It is a concatenation of one or more words consisting of English letters.
All letters in the first word are lowercase.
For each of the subsequent words, the first letter is uppercase and rest of the letters are lowercase.
Given , print the number of words in  on a new line.

Input Format

A single line containing string .

Constraints

Output Format

Print the number of words in string .
*/
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            int wordCount = 0;
            foreach (char c in test)
            {
                if (c < 'a')
                {
                    wordCount++;
                }
            }

            Console.WriteLine(wordCount + 1);

        }
    }
}
