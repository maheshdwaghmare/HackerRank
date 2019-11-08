using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int d1 = 0, d2 = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                    {
                        d1 += arr[i][j];
                    }

                    if (i == arr.Count() - j - 1)
                        d2 += arr[i][j];
                }
            }


            return Math.Abs(d1 - d2);
        }

        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<int>> arr = new List<List<int>>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //    }

        //    int result = DiagonalDifference.diagonalDifference(arr);

        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}
    }
}
