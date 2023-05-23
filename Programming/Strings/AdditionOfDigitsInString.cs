using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class AdditionOfDigitsInString
    {
        static void aain(String[] args)
        {
            String s = "a2BC5d1";
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (ch >= '0' && ch <= '9')
                {
                    int n = ch - 48;
                    sum = sum + n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
