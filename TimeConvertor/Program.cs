using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConvertor
{
    class Program
    {
        enum Increment { HOUR, MINUTE, SECOND }

        static void Main(string[] args)
        {
            string twelveTime = Console.ReadLine();
            string[] tokens = twelveTime.Split(':');
            string meridian = tokens[(int)Increment.SECOND].Substring(2);
            tokens[(int)Increment.SECOND] = tokens[(int)Increment.SECOND].Substring(0, 2);

            string sHour = tokens[(int)Increment.HOUR];
            if (meridian == "PM")
            {
                int hour = Int32.Parse(sHour);
                //12:00:00PM => 12:00:00 (24hour)
                if (hour != 12)
                {
                    hour += 12;
                    sHour = hour.ToString();
                }
            }
            else
            {
                int hour = Int32.Parse(sHour);
                //12:00:00AM => 00:00:00 (24hour)
                if (hour == 12)
                {
                    sHour = "00";
                }
            }

            Console.WriteLine(string.Format("{0}:{1}:{2}", sHour, tokens[(int)Increment.MINUTE], tokens[(int)Increment.SECOND]));


            Console.ReadLine();
        }
    }
}
