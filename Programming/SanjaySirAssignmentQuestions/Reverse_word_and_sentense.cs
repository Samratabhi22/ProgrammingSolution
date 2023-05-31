using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Reverse_word_and_sentense
    {
        public static void Maftgin(String[] args)
        {
            Console.WriteLine("19--> reverse_word_and_sentense");
            String s = "my name is ok";
            //ko si eman ym 
          
            String[] strArr = s.Split(" ");
            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                String s1 = null;
                string substr = strArr[i];
                for (int j = substr.Length - 1; j >= 0; j--)
                {
                    s1 = s1 + substr[j];
                }
                Console.Write(s1+" ");
            }
         

        }
    }
}
