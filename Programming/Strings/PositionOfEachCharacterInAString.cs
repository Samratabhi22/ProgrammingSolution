using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class PositionOfEachCharacterInAString
    {
        static void Mlain()
        {
            String st = "Kannada";

            String s = st.ToLower();
            //LinkedHashSet<Character> set = new LinkedHashSet<Character>();
            for (int i = 0; i < s.Length; i++)
            {
                //set.add(s.charAt(i));
                Console.WriteLine(s[i] + " is present in " + (i + 1) + " position");

            }

        }

    }
}
