using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class BalancedBrackets
    {
        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (c == '{') stack.Push('}');
                else if (c == '(') stack.Push(')');
                else if (c == '[') stack.Push(']');
                else
                {
                    if (stack.Count == 0 || c != (char)stack.Peek())
                        return "NO";
                    stack.Pop();
                }
            }
            return stack.Count == 0 ? "YES" : "NO";
        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        string s = Console.ReadLine();

        //        string result = isBalanced(s);

        //        //textWriter.WriteLine(result);
        //        Console.WriteLine(result);
        //        Console.ReadKey();
        //    }

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
