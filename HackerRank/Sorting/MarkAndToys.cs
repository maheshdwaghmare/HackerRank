using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class MarkAndToys
    {
        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            Array.Sort(prices);
            int i = 0;
            while (k - prices[i] >= 0)
            {
                k = k - prices[i];
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            int result = maximumToys(prices, k);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
