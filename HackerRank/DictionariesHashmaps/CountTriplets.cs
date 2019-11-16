using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class CountTriplets
    {
        // Complete the countTriplets function below.
        static long countTriplets(List<long> arr, long r)
        {
            long triplets = 0;
            Dictionary<long, long> dict = new Dictionary<long, long>();
            Dictionary<long, long> dictPairs = new Dictionary<long, long>();

            for (int index = arr.Count - 1; index >= 0; index--)
            {
                if (dictPairs.ContainsKey(arr[index] * r))
                    triplets += dictPairs[arr[index] * r];

                if (dict.ContainsKey(arr[index] * r))
                {
                    if (dictPairs.ContainsKey(arr[index]))
                        dictPairs[arr[index]] = dictPairs[arr[index]] + dict[arr[index] * r];
                    else
                        dictPairs[arr[index]] = dict[arr[index] * r];
                }

                if (!dict.ContainsKey(arr[index]))
                    dict.Add(arr[index], 1);
                else
                    dict[arr[index]]++;
            }

            return triplets;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            long ans = countTriplets(arr, r);

            Console.WriteLine(ans);
            //textWriter.WriteLine(ans);

            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
