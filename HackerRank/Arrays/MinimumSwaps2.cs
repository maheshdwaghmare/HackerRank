using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class MinimumSwaps2
    {
        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (i + 1 != arr[i])
                {
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    count += 1;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
            Console.ReadKey();

            //textWriter.WriteLine(res);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
