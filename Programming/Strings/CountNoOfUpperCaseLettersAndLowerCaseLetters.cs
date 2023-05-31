using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class CountNoOfUpperCaseLettersAndLowerCaseLetters
    {
        public static void Mbnain()
        {
            String s = "SofTwArE";
            int uppercase = 0;
            int lowercase = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    lowercase++;

                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    uppercase++;
                }

            }
            Console.WriteLine("uppercaseletter :" + uppercase);
            Console.WriteLine("lowercaseletter :" + lowercase);


        }
    }
}
