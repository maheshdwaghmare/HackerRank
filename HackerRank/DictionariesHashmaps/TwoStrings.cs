using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class TwoStrings
    {
        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s1.ToCharArray())
            {
                if (dict.ContainsKey(c))
                    dict[c] += 1;
                else
                    dict.Add(c, 1);
            }

            foreach (char c in s2.ToCharArray())
            {
                if (dict.ContainsKey(c))
                {
                    return "Yes";
                }
            }

            return "No";
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadKey();
        }
    }
}
