using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class BirthdayCakeCandles
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int highestCandle = ar.Max();
            int candleCounter = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == highestCandle)
                    candleCounter++;
            }

            return candleCounter;
        }
        //static void Main(string[] args)
        //{
        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //    ;
        //    int result = birthdayCakeCandles(ar);

        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}
    }
}
