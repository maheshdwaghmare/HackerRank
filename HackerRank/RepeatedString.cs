using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            decimal d = n / s.Length;
            long x = Convert.ToInt64(Math.Floor(d));
            long count = (s.Split('a').Length - 1) * x;
            long rem = n % s.Length;

            for (int i = 0; i < rem; i++)
            {
                if (s.ElementAt(i) == 'a')
                    count++;
            }

            return count;
        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    long n = Convert.ToInt64(Console.ReadLine());

        //    long result = repeatedString(s, n);

        //    //textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
