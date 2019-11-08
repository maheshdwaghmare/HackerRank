using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class JumpingClouds
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {   
            int count = 0;
            int i = 0;

            while (true)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i += 2;
                }
                else if (i + 1 < c.Length)
                {
                    i++;
                }
                else
                {
                    break;
                }
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
