using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Length_ofString_withoutLength_function
    {
        static void Mafdfslin()
        {
           
            String s = "abhishek";
            char[] strArr = s.ToCharArray();
            int lengthOfString = 0;
            foreach (char c in strArr)
            {
                lengthOfString++;
            }
            Console.WriteLine("lengthOfString >>   " + lengthOfString);

        }
    }
}
