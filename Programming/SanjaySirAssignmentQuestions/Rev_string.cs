using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Rev_string
    {
        public static void Msdain(String[] args)
        {
           
            String s = "i am selenium";
            //selenium am i
            String rev = "";
           // string s = "my name is abhishek";
            //abhishek is name my
          //  string rev = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    Console.Write(rev + " ");
                    rev = "";
                }
                else
                {

                    rev = s[i] + rev;
                }

            }


            Console.Write(rev);

        }
    }
}
