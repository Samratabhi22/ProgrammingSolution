using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CSharpFundas
{
    internal class PrintCountAndAlphas
    {
        static void Madin()
        {
            string s = "aabbcccdd";
             //string s = "aabbcccddaabb";
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                        i++;

                    }
                }
                Console.Write(s[i] + "" + count);
            }

        }
    }
    class NameEvenOdd
    {
        static void Maikn()
        {
            string[] st = { "abhishek", "abhirk", "vahrun" };
         

                for(int i=0;i<st.Length;i++)
            {
                string str = st[i];
                if (str.Length%2==0)
                {
                    for(int j = str.Length-1;j>=0;j--)
                    {
                        Console.Write(str[j]);
                    }
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(st[i]+" ");
                }
            }
        }
    }
   

class CountPrintAlpha
    {
        static void Matin(string[] args)
        {

            string s = "aabbcccddaabb";
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length;i++)
            {
                int count = 1;
                for(int j=i+1;j<c.Length;j++)
                {
                    if (c[i] == c[j])
                    {
                        count++;
                        c[j] = '#';
                    }
                }
                if (c[i]!='#')
                {
                    Console.Write(c[i]+""+count+" ");
                }
            }
            
        }
    }
    class PrintSameNumbers
    {
        static void Mainnn()
        {
            for (int number = 11; number <= 1000; number++)
            {
                int digit = number % 10;
                int remainingNumber = number / 10;

                bool allDigitsSame = true;
                while (remainingNumber > 0)
                {
                    int currentDigit = remainingNumber % 10;
                    if (currentDigit != digit)
                    {
                        allDigitsSame = false;
                        break;
                    }
                    remainingNumber /= 10;
                }

                if (allDigitsSame)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
    

}
