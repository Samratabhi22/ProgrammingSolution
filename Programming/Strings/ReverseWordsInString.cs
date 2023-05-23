using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class ReverseWordsInString
    {
        static void Mawin()
        {
            String s = "I am a software engineer";//I ma a erawtfos reenigne
            String[] st = s.Split(" ");// Iamasoftwareengineer
            for (int i = 0; i < st.Length; i++)
            {
                String str = st[i];
                Console.Write(str);//Iamasoftwareengineer
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    //i= 0 0<5 true st[i]= I
                    //i= 1 1<5 true st[i]= am
                    //i= 2 2<5 true st[i]= a
                    //i= 3 3<5 true st[i]= software
                    //i= 4 4<5 true st[i]= engineer


                    Console.Write(str[j]);        //I ma a erawtfos reenigne
                }
                Console.Write(" ");

            }

        }
    }
}
