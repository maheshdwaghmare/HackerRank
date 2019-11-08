using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class MiniMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long minValue = long.MaxValue;
            long maxValue = long.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        sum += arr[j];
                }

                if (sum > maxValue)
                    maxValue = sum;

                if (sum < minValue)
                    minValue = sum;
            }

            Console.WriteLine(minValue + " " + maxValue);
            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    miniMaxSum(arr);
        //}

    }
}
