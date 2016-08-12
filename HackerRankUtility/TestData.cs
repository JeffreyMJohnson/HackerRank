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
    /// 
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
