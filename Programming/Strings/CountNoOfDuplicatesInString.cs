using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class CountNoOfDuplicatesInString
    {
        public static void wain()
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
                if (count > 1)
                {
                    Console.WriteLine(ch + " is repeating  " + count + " times");
                }

            }

        }
    }
}
