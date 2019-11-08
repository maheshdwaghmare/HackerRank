using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class CompareTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int counterA = 0, counterB = 0;
            for (int i = 0; i < a.Count() && i < b.Count(); i++)
            {
                if (a[i] > b[i])
                    counterA++;
                else if (a[i] == b[i])
                    continue;
                else
                    counterB++;
            }

            result.Add(counterA);
            result.Add(counterB);
            return result;
        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //    List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        //    List<int> result = compareTriplets(a, b);

        //    Console.WriteLine(String.Join(" ", result));
        //    Console.ReadKey();

        //    //textWriter.WriteLine(String.Join(" ", result));

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
