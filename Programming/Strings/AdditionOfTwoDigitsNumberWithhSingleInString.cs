using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class AdditionOfTwoDigitsNumberWithhSingleInString
    {
        static void cain()
        {
            //String s="a11b12c2";
            String s = "a111b12c2";

            int sum = 0;         //0 11  23
            int tsum = 0;            // 0 1 11 0 1 12 0 2
            for (int i = 0; i < s.Length; i++)
            {
                //i=8 ; 8<8 f ,terminate
                char ch = s[i];
                if (ch >= '0' && ch <= '9')
                {
                    int n = ch - 48;//50-48=2
                    tsum = tsum * 10 + n;
                }
                else
                {
                    sum = sum + tsum;//11+12=23
                    tsum = 0;//0

                }
            }
            sum = sum + tsum;//23+2=25
            Console.WriteLine(sum);//25

        }
    }
}
