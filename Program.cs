using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoImproveYouSelf
{
    class Program
    {


        // Complete the appendAndDelete function below.
        static string appendAndDelete(string s, string t, int k)
        {
            var end = 0;

            for (var i = 0; i < Math.Min(t.Length, s.Length); i++)
            {
                if (s[i] == t[i])
                {
                    end++;
                }
                else
                {
                    break;
                }
            }

            var maxIter = s.Length + t.Length;
            var minIter = maxIter - (2 * end);


            if ((k >= minIter) & ((k - minIter) % 2 == 0))
            {
                return "Yes";
            }
            else if (k >= maxIter)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
    
        }

        static void Main(string[] args)
        {

            string s = "hackerhappy";

            string t = "hackerrank";

            int k = 7;

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
