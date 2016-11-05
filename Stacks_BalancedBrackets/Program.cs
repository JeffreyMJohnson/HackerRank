#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankUtility;



namespace Stacks_BalancedBrackets
{
    class Program
    {
        /*The first line contains a single integer, `n`, denoting the number of strings. 
Each line `i` of the `n` subsequent lines consists of a single string, `s`, denoting a sequence of brackets.
*/
        /*For each string, print whether or not the string of brackets is balanced on a new line. If the 
         * brackets are balanced, print YES; otherwise, print NO.*/
        static void Main(string[] args)
        {
#if TEST
            string[] input = TestData.Get("data/TC_4.txt");
            int numStrings = Convert.ToInt32(input[0]);
            for (int i = 0; i < numStrings; ++i)
            {
                string expression = input[i + 1];
                string isBalanced = IsBalanced(expression) ? "YES" : "NO";
                Console.WriteLine(isBalanced);
            }
#else
            int numStrings = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numStrings; ++i)
            {
                string expression = Console.ReadLine();
                string isBalanced = IsBalanced(expression) ? "YES" : "NO";
                Console.WriteLine(isBalanced);
            }

#endif

        }

        /*Given  strings of brackets, determine whether each sequence of brackets is balanced. If a string 
         * is balanced, print YES on a new line; otherwise, print NO on a new line.*/

        static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            //loop through expression
            foreach (char c in expression)
            {
                //if char open bracket
                if (IsOpenBracket(c))
                {
                    //push open bracket to stack
                    stack.Push(c);
                    //continue loop
                    continue;
                }
                //if char close bracket
                if (IsCloseBracket(c))
                {
                    
                    //if stack count > 0 AND char opposite match of top stack
                    if (stack.Count > 0 && IsOppositeBracketMatch(stack.Peek(), c))
                    {
                        //pop char off stack
                        stack.Pop();
                        //continue loop
                        continue;
                    }
                    else//else
                    {
                        //return false
                        return false;
                    }
                }
            }//end loop
            //if stack is empty
                //return true
            //else
                //return false
            return stack.Count == 0;
        }

        static bool IsOpenBracket(char c)
        {
            return
                c == '[' ||
                c == '{' ||
                c == '(';
        }

        static bool IsCloseBracket(char c)
        {
            return
                c == ']' ||
                c == '}' ||
                c == ')';
        }

        static bool IsOppositeBracketMatch(char a, char b)
        {
            switch (a)
            {
                case '[':
                    return b == ']';
                    break;
                case '{':
                    return b == '}';
                    break;
                case '(':
                    return b == ')';
                    break;
                case ']':
                    return b == '[';
                    break;
                case '}':
                    return b == '{';
                    break;
                case ')':
                    return b == '(';
                    break;
            }
            return false;
        }
    }
}
