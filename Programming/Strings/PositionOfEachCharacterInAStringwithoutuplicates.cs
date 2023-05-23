using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class PositionOfEachCharacterInAStringwithoutuplicates
    {
        static void Msain()
        {
            String st = "Kannada"; //k=1 a=2 n=3 d=6

            String s = st.ToLower();
            HashSet<Char> set = new HashSet<Char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);

            }
            foreach (Char ch in set)
            {
                //System.out.println(ch+" ");
                //int count =0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (ch == s[i])
                    {
                        Console.WriteLine(s[i] + " is present in " + (i + 1) + " position");
                        break;
                    }

                }

            }

        }
    }
}
