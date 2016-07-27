//#define TESTING

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankUtility;




namespace RectangularGame2
{
    /*
     You are given an infinite 2-d grid with the bottom left cell referenced as (1,1). All the cells contain a value of zero initially. Let's play a game?

The game consists of N steps wherein each step you are given two integers a and b. The value of each of the cells in the co-ordinate (u, v) satisfying 1 ≤ u ≤ a and 1 ≤ v ≤ b, is increased by 1. After N such steps, if X is the largest number amongst all the cells in the rectangular board, can you print the number of X's in the board?

   Input Format 
The first line of input contains a single integer N. N lines follow. 
Each line contains two integers a and b separated by a single space.

Output Format 
Output a single integer - the number of X's.

Constraints 
1 ≤ N ≤ 100 
1 ≤ a ≤ 10^6 
1 ≤ b ≤ 10^6
*/

    class Program
    {
        public const string TEST_FILE_PATH = "data/test01.txt";

        class Data
        {
            public uint lines = 0;
            public List<Tuple<ulong, ulong>> coords = new List<Tuple<ulong, ulong>>();
        }

        static Data LoadData()
        {
            Data data = new Data();
#if TESTING
            string[] dataList = TestData.Get(TEST_FILE_PATH);
#else
            string[] dataList = TestData.Get();
#endif
            /*
               Input Format 
            The first line of input contains a single integer N. N lines follow. 
            Each line contains two integers a and b separated by a single space.
            */
            data.lines = UInt32.Parse(dataList[0]);
            for (int i = 1; i < dataList.Length; ++i)
            {
                string line = dataList[i];
                string[] tokens = line.Split(' ');
                ulong a = ulong.Parse(tokens[0]);
                ulong b = ulong.Parse(tokens[1]);
                data.coords.Add(new Tuple<ulong, ulong>(a, b));
            }

            return data;
        }

        static Tuple<ulong, ulong> GetMin(Data data)
        {
            ulong minA = ulong.MaxValue;
            ulong minB = ulong.MaxValue;
            foreach (Tuple<ulong, ulong> coord in data.coords)
            {
                if (coord.Item1 < minA)
                {
                    minA = coord.Item1;
                }
                if (coord.Item2 < minB)
                {
                    minB = coord.Item2;
                }
            }
            return new Tuple<ulong, ulong>(minA, minB);
        }

        static void Main(string[] args)
        {
            Data data = LoadData();
            Tuple<ulong, ulong> mins = GetMin(data);
            Console.WriteLine(mins.Item1 * mins.Item2);
            Console.ReadKey();
        }
    }
}
