#define TESTING
using System;
using System.Collections.Generic;
using System.Linq;
using HackerRankUtility;

namespace Making_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        { 
            string a, b;
#if TESTING
            string[] data = TestData.Get("data/data1.txt");
            a = data[0];
            b = data[1];
#else
            a = Console.ReadLine();
            b = Console.ReadLine();
#endif
            int result = MinAnagramDelete(a, b);

            Console.WriteLine(result);
        }

        static int MinAnagramDelete(string a, string b)
        {
            Dictionary<char, int> aFrequency = GetCharFrequency(a);
            Dictionary<char, int> bFrequency = GetCharFrequency(b);

            char[] keys = aFrequency.Keys.ToArray<char>();
            foreach(var key in keys)
            {
                //is there a matching key
                if (bFrequency.ContainsKey(key))
                {
                    int newValue = Math.Abs(aFrequency[key] - bFrequency[key]);
                    aFrequency[key] = 0;
                    bFrequency[key] = newValue;
                }
            }

            //result should be everything left
            int result = 0;
            foreach(var entry in aFrequency)
            {
                result += entry.Value;
            }
            foreach(var entry in bFrequency)
            {
                result += entry.Value;
            }

            return result;
        }

        static Dictionary<char, int> GetCharFrequency(string a)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach(char c in a)
            {
                if(result.ContainsKey(c))
                {
                    ++result[c];
                }
                else
                {
                    result.Add(c, 1);
                }
            }
            return result;
        }
    }
}
