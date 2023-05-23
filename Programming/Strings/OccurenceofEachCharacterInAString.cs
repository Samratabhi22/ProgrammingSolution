using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class OccurenceofEachCharacterInAString
    {
         static void jjain()
        {
            String st = "Kannada";

            String s = st.ToLower();
            HashSet<Char> set = new HashSet<Char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);

            }
            foreach (Char ch in set)
            {
                //System.out.println(ch+" ");
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (ch == s[i])
                    {
                        count++;
                    }

                }
                Console.WriteLine(ch + " is repeating  " + count + " times");

            }


        }
    }
}
