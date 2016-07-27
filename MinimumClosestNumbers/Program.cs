using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumClosestNumbers
{
    class Program
    {
        /*
         generate list of all possible pairs
            loop through the array with counter i
                
         */
        static List<Tuple<int, int>> GetAllPairs(int[] numbers)
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            List<int> numList = new List<int>(numbers);
            numList.Sort();
            for (int i = 0; i < numList.Count; ++i)
            {
                for (int j = i + 1; j < numList.Count; ++j)
                {
                    result.Add(new Tuple<int, int>(numList[i], numList[j]));
                }
            }
            return result;
        }

        static void OutputList(List<Tuple<int, int>> list)
        {
            foreach (Tuple<int, int> pair in list)
            {
                Console.WriteLine(pair.Item1 + " " + pair.Item2);
            }
        }

        static void closestNumbers(int[] numbers)
        {
            List<Tuple<int, int>> possiblePairs = GetAllPairs(numbers);
            List<Tuple<int,int>> minPairs = new List<Tuple<int, int>>();
            int lowestMin = Int32.MaxValue;
            foreach (Tuple<int, int> pair in possiblePairs)
            {
                int absMin = Math.Abs(pair.Item1 - pair.Item2);
                if (absMin <= lowestMin)
                {
                    //clear if new lowest value
                    if (absMin < lowestMin)
                    {
                        minPairs.Clear();
                        lowestMin = absMin;
                    }
                    minPairs.Add(pair);
                    
                }
            }

            OutputList(minPairs);
        }


        static void Main(string[] args)
        {
            int[] test = new[] {4,-2,-1,3};
            closestNumbers(test);

            Console.ReadLine();

        }
    }
}
