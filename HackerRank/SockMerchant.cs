using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class SockMerchant
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int i, pair = 0, temp, j, count = 1;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (ar[j] > ar[j + 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }

            bool isCalculated = false;
            for (i = 0; i < n - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    count++;
                    isCalculated = false;
                }
                else
                {
                    if (ar[i] != ar[i + 1])
                    {
                        pair = pair + (count / 2);
                        count = 1;
                    }

                    isCalculated = true;
                }
            }

            if (!isCalculated)
                pair = pair + (count / 2);

            return pair;
        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //    int result = sockMerchant(n, ar);

        //    //textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
