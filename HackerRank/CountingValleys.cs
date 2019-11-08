using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class CountingValleys
    {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            char[] arr = s.ToCharArray();
            int count = 0;
            int level = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'U')
                {
                    ++level;
                }
                if (arr[i] == 'D')
                {
                    level--;
                }
                if (level == 0 && arr[i] == 'U')
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
