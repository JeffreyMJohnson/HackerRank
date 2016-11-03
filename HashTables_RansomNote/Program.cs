#define TESTING
using HackerRankUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A kidnapper wrote a ransom note but is worried it will be traced back to him. He found a magazine 
and wants to know if he can cut out whole words from it and use them to create an untraceable 
replica of his ransom note. The words in his note are case-sensitive and he must use whole words 
available in the magazine, meaning he cannot use substrings or concatenation to create the words 
he needs.

Given the words in the magazine and the words in the ransom note, print Yes if he can replicate 
his ransom note exactly using whole words from the magazine; otherwise, print No.

Input Format
The first line contains two space-separated integers describing the respective values of M 
(the number of words in the magazine) and N (the number of words in the ransom note). 
The second line contains M space-separated strings denoting the words present in the magazine. 
The third line contains N space-separated strings denoting the words present in the ransom note.

Constraints
* 1 <= M,N <= 30000
* 1 <= length of any word <= 5
* Each word consists of English alphabetic letters (i.e., a to z and A to Z).
* The words in the note and magazine are case-sensitive.

Output Format
Print Yes if he can use the magazine to create an untraceable replica of his ransom note; 
otherwise, print No.
 */

namespace HashTables_RansomNote
{
    class Program
    {
        //convert magazine to word frequency (hash map)
        //loop note words
            //if word is in magazine word freq map
                //if word freq count is > 1
                    //set word freq count -= 1
                //else
                    //remove word from freq map
            //else
                //return "No"
        //end loop
        //return "Yes"
        private static Dictionary<string, int> GetWordFrequencyMap(string[] list)
        {
            Dictionary<string,int> wordFrequency = new Dictionary<string, int>();
            foreach (string s in list)
            {
                if (wordFrequency.ContainsKey(s))
                {
                    wordFrequency[s]++;
                }
                else
                {
                    wordFrequency.Add(s, 1);
                }
            }
            return wordFrequency;
        }


        private static string CanUseMagazine(string[] magazine, string[] ransom)
        {
            Dictionary<string, int> magazineWordFrequency = GetWordFrequencyMap(magazine);
            foreach (string s in ransom)
            {
                if (magazineWordFrequency.ContainsKey(s))
                {
                    if (magazineWordFrequency[s] > 1)
                    {
                        magazineWordFrequency[s]--;
                    }
                    else
                    {
                        magazineWordFrequency.Remove(s);
                    }
                }
                else
                {
                    return "No";
                }
            }
            return "Yes";
        }

        static void Main(string[] args)
        {
#if TESTING
            string[] input = TestData.Get("data/data_1.txt");
            string[] tokens_m =input[0].Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = input[1].Split(' ');
            string[] ransom = input[2].Split(' ');
#else
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');
#endif
            string answer = CanUseMagazine(magazine, ransom);

            Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}
