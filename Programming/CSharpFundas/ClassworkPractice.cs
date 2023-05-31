using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CSharpFundas
{
    internal class ClassworkPractice
    {
        static void Madin()
        {
            string name = "ABHI1234SHEK";
            string alpha = "";
            string numb = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                {
                    Console.Write(name[i]);
                }

                /*
                 if (name[i] >= '0' && name[i] <= '9')
                 {
                     numb=numb+ name[i];
                 }
                 else
                 {
                     alpha=alpha+ name[i];   
                 }*/

            }
            Console.WriteLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9') { }
                else
                {
                    //Console.WriteLine();
                    Console.Write(name[i]);
                    //  Console.Write("Alphabets :- " + name[i]);
                }


            }

        }

    }
    class AdditionOfStrings
    {
        static void Maibnn()
        {
            string name = "Abhishek";

            string fname = "Bijay";
            for (int i = 0; i < name.Length; i++)
            {
                char chname = name[i];
            }
            for (int i = 0; i < fname.Length; i++)
            {
                char chfname = fname[i];
            }

        }
    }
}
