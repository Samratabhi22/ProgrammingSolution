using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Remove_space
    {
        public static void Makmnhin(String[] args)
        {
            Console.WriteLine("9--> remove_space");
            String s = "my name is abc";
           // String[] str = s.Split(" ");
          String s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    s1 = s1 + s[i];
                }
            }
            //		for (String strg : str) {
            //			System.out.print(strg);
            //		}
            Console.WriteLine(s1);

        }

    }
}
