using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class CountNoOfVowelsInAString
    {
        static void gain()
        {
            String st = "Engineer";

            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < st.Length; i++)
            {
                char ch = st[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowels++;

                }
                else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }

            }

            Console.WriteLine("vowels :" + vowels);
            Console.WriteLine("consonants :" + consonants);



        }
    }
}
