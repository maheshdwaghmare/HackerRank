using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class BigSum
    {
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            foreach (long val in ar)
            {
                result += val;
            }

            return result;
        }

        //static void Main(string[] args)
        //{   
        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        //    ;
        //    long result = aVeryBigSum(ar);

        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}
    }
}
