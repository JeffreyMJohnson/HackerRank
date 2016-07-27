using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zigzag_array
{
    class Program
    {

        static int[] wiggleArrangeArray(int[] intArr)
        {
            List<int> result = new List<int>();
            List<int> sortAscend = new List<int>(intArr);
            sortAscend.Sort();
            int halfWay = (int)(sortAscend.Count * .5);
            int lowest = 0;
            int highest = sortAscend.Count - 1;
            while (result.Count < sortAscend.Count)
            {
                result.Add(sortAscend[highest--]);
                if (lowest + 1 < highest)
                {
                    result.Add(sortAscend[lowest++]);
                }
            }
            return result.ToArray();

        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 5, 2, 7, 8, -2, 25, 25 };
            int[] result = wiggleArrangeArray(test);
        }
    }
}
