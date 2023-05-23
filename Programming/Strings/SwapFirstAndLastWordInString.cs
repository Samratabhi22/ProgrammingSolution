using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class SwapFirstAndLastWordInString
    {
        static void Mbain(String[] args)
        {
            String s = "I am a software engineer";//engineer am a software I 
            String[] st = s.Split(" ");

            //st[0] = I , st[1] = am ,st[2] = a, st[3] = Software,st[4]/st[length-1] = Engineer 
            //int a= 10;
            //int b= 20;
            //int temp =a;
            //a=b;
            //b=temp;
            String temp = st[0];
            st[0] = st[st.Length - 1];
            st[st.Length - 1] = temp;
            for (int i = 0; i < st.Length; i++)
            {
                Console.Write(st[i] + " ");

            }

        }

    }
}
