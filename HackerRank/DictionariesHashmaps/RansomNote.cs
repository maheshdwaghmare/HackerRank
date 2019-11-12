using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class RansomNote
    {
        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazine, string[] note)
        {
            string output = "Yes";
            Dictionary<string, int> dictMagazine = new Dictionary<string, int>();
            foreach (string word in magazine)
            {
                if (dictMagazine.ContainsKey(word))
                    dictMagazine[word] += 1;
                else
                    dictMagazine.Add(word, 1);
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (dictMagazine.ContainsKey(note[i]))
                {
                    dictMagazine[note[i]] -= 1;
                    if (dictMagazine[note[i]] == 0)
                        dictMagazine.Remove(note[i]);
                }
                else
                {
                    output = "No";
                    break;
                }
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    string[] mn = Console.ReadLine().Split(' ');

        //    int m = Convert.ToInt32(mn[0]);

        //    int n = Convert.ToInt32(mn[1]);

        //    string[] magazine = Console.ReadLine().Split(' ');

        //    string[] note = Console.ReadLine().Split(' ');

        //    checkMagazine(magazine, note);
        //}
    }
}
