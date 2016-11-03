using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankUtility
{
    /// <summary>
    /// Use this helper class to simulate the HackerRank site's I/O concept with a
    /// loaded data file.  Use a <code>#define TEST</code> tag and can just copy the 
    /// code straight to the site.
    /// 
    ///<example>
    ///#if TEST
    ///            string[] input = TestData.Get("data/data_1.txt");
    ///            string[] tokens = input[0].Split(' ');
    ///            int numOfIntegers = Int32.Parse(tokens[0]);
    ///            int numRotations = Int32.Parse(tokens[1]);
    ///            tokens = input[1].Split(' ');
    ///#else
    ///            string[] tokens = Console.ReadLine().Split(' ');
    ///            int numOfIntegers = Int32.Parse(tokens[0]);
    ///            int numRotations = Int32.Parse(tokens[1]);
    ///            tokens = Console.ReadLine().Split(' ');
    ///#endif
    ///            int[] array = Array.ConvertAll(tokens, Int32.Parse);
    ///            int[] result = LeftShift(array, numRotations);
    /// </example> 
    /// </summary>
    public static class TestData
    {
        public static string[] Get()
        {
            List<string> dataList = new List<string>();
            dataList.Add(Console.ReadLine());
            int numLines = int.Parse(dataList[0]);
            for (int i = 0; i < numLines; ++i)
            {
                dataList.Add(Console.ReadLine());
            }
            return dataList.ToArray();
        }
        /// <summary>
        /// Returns string array of each line of the given text file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] Get(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path + " not found.");
            }
            List<string> dataList = new List<string>();
            using (StreamReader stream = File.OpenText(path))
            {

                string data = "";
                while ((data = stream.ReadLine()) != null)
                {
                    dataList.Add(data);
                }
            }
            return dataList.ToArray();


        }
    }
}
