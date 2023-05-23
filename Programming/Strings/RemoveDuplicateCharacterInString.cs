using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class RemoveDuplicateCharacterInString
    {
         static void Maiggn()
        {
            String s = "Kannada";

           // String st = s.ToLower();

            //Console.Write(st);


            HashSet<Char> set = new HashSet<Char>();


            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);

            }


            foreach (Char ch in set)
            {
                Console.Write(ch + " ");
            }

        }
    }
}
