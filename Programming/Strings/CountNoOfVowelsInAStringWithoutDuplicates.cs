using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class CountNoOfVowelsInAStringWithoutDuplicates
    {
        static void ghain()
        {
            String st = "Engineer";
            String s = st.ToLower();
            char[] str = s.ToCharArray();
           
            HashSet<Char> set = new HashSet<Char>();
            for (int i = 0; i < str.Length; i++)
            {

                set.Add(str[i]);

            }
            int count = 0;
            foreach (char ch in set)
            {

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                    Console.Write(ch);

                }

            }
            Console.Write(" = " + count);
        }
    }
}
