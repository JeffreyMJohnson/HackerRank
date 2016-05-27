using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyProfessor
{
    /*
     * A Discrete Mathematics professor has a class of N students. Frustrated with their lack of discipline, he decides to cancel class 
     * if fewer than K students are present when class starts.

        Given the arrival time of each student, determine if the class is canceled.
     * 
     * 
     * Input Format

The first line of input contains T, the number of test cases.

Each test case consists of two lines. The first line has two space-separated integers, N (students in the class) and K (the cancelation threshold). 
The second line contains N space-separated integers (a1,a2, ... , aN) describing the arrival times for each student.

Note: Non-positive arrival times (ai <= 0) indicate the student arrived early or on time; positive arrival times (ai > 0) indicate the student
arrived ai minutes late.

        Output Format

For each test case, print the word YES if the class is canceled or NO if it is not.

        Constraints
        1 <= T <= 10
        1 <= N <= 1000
        1 <= K <= N
        -100 <= ai <= 100, i => [1, N]

Note 
If a student arrives exactly on time (ai = 0), the student is considered to have entered before the class started.
     * 
     */
    class Program
    {
        private static string[] _sampleInput =
        {
            "2",
            "4 3",
            "-1 -3 4 2",
            "4 2",
            "0 -1 2 1"
        };

        static void Main(string[] args)
        {
            //int numTestCases = Int32.Parse(_sampleInput[0]);
            int numTestCases = Convert.ToInt32(Console.ReadLine());
            int inputIndex = 1;
            for (int i = 0; i < numTestCases; i++)
            {

                //string[] paramaters = _sampleInput[inputIndex++].Split(' ');
                string[] paramaters = Console.ReadLine().Split(' ');
                int studentsInClass = Convert.ToInt32(paramaters[0]);
                int cancellationThreshold = Convert.ToInt32(paramaters[1]);

                //string[] arrivalTimesAsString = _sampleInput[inputIndex++].Split(' ');
                string[] arrivalTimesAsString = Console.ReadLine().Split(' ');
                int[] arrivalTimes = Array.ConvertAll(arrivalTimesAsString, Int32.Parse);

                int onTimeCount = 0;
                for (int j = 0; j < studentsInClass; j++)
                {
                    if (arrivalTimes[j] <= 0)
                    {
                        onTimeCount++;
                    }
                }
                bool isCancelled = onTimeCount < cancellationThreshold;

                Console.WriteLine(isCancelled ? "YES" : "NO");
            }
            //Console.ReadLine();
        }
        
    }
}
