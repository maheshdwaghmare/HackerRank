using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            double fractionPositive = 0;
            double fractionZero = 0;
            double fractionNegative = 0;

            double pos = arr.Where(a => a > 0).Count();
            double neg = arr.Where(a => a < 0).Count();
            double zero = arr.Where(a => a == 0).Count();

            fractionPositive = pos / n;
            fractionNegative = neg / n;
            fractionZero = zero / n;

            Console.WriteLine(fractionPositive);
            Console.WriteLine(fractionNegative);
            Console.WriteLine(fractionZero);

            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //    ;
        //    plusMinus(arr);
        //}
    }
}
