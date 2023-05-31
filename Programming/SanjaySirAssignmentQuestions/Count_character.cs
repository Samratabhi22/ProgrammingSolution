using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Count_character
    {
        static void Maasdain()
        {
            
           // System.out.println("6--> count_char_and_print_format char:count");
            String s = "Malayalam";
            s = s.ToLower();
            HashSet<Char> set = new HashSet<Char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            foreach (Char character in set)
            {

                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (character == s[i])
                    {
                        count++;
                    }
                }
                Console.Write(character + " : " + count+" , ");
            }
            Console.WriteLine();
        }
    }
}
