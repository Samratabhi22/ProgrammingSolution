using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class ReverseSentenceWithoutUsingSplitMethod
    {
        
        static void Manin()
        
        {
            string s = "my name is abhishek";
            //abhishek is name my
            string rev = "";
          
            for(int i=s.Length-1;i>=0;i--)
            {
                if (s[i]==' ')
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

    

