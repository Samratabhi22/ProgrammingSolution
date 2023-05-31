using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class FindMinimumLengthOfStringInStringArray
    {
         static void jvain()
        {
            String[] s = { "abc", "dv", "abcdd", "abcd", "ab" };
            String min_length = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (min_length.Length > s[i].Length)
               /// if(min_length.Length<s[i].Length)
                {
                    min_length = s[i];
                }
            }
          //  Console.WriteLine(min_length);


            //for  2 same min length
            //	String[] s= {"abc","dv","abcdd","abcd","ab"};
            //	String min_length=s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (min_length.Length == s[i].Length)
                {
                    Console.WriteLine(s[i] + " ");
                   // break;
                }
            }



        }
    }
}
