using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class ReverseSentence
    {
        static void Madin()
        {
            String s = "I am a software engineer";//engineer software a am I
            String[] st = s.Split(" ");
            for (int i = st.Length - 1; i >= 0; i--)
            {
                Console.Write(st[i] + " ");

            }
            // Console.WriteLine("=================");
            //String str = "abhishek";
            //String[] strng = str.Split("");
            //for (int i = strng.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(strng[i]);

            //}

        }
    }
}
