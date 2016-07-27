using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {

        static int lonelyInteger(int[] arr)
        {
            Dictionary<int, int> charCount = new Dictionary<int, int>();
            
            foreach (int i in arr)
            {
                if (charCount.ContainsKey(i))
                {
                    charCount[i]++;
                }
                else
                {
                    charCount.Add(i, 1);
                }
                
            }

            foreach (int i in charCount.Keys)
            {
                if (charCount[i] == 1)
                {
                    return i;
                }
            }
            throw new Exception("should never get here. fix this!");
        }


        static void Main(string[] args)
        {
            int[] test = new[] {1, 1, 2};
            int result = lonelyInteger(test);

        }
    }
}
