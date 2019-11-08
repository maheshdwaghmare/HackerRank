using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class _2DArray
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            if (arr.Length < 3)
                return -1;

            // Here loop runs (R-2)*(C-2) times considering different top left cells of hour glasses. 
            int max_sum = int.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    // Considering mat[i][j] as top left cell of hour glass. 
                    int sum = (arr[i][j] + arr[i][j + 1] +
                               arr[i][j + 2]) + (arr[i + 1][j + 1]) +
                              (arr[i + 2][j] + arr[i + 2][j + 1] +
                               arr[i + 2][j + 2]);

                    // If previous sum is less then current sum then update new sum in max_sum 
                    max_sum = Math.Max(max_sum, sum);
                }
            }

            return max_sum;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
