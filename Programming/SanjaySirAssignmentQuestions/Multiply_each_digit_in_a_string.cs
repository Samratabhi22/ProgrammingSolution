using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Multiply_each_digit_in_a_string
    {
        static void Maifdn()
        {
            
            
            String str = "v1i2n3ay4 p5ri1ya23n5k7a";
            int len, x, mul = 1;
         
            len = str.Length;
            for (int i = 0; i < len; i++)
            {
                x = str[i] - '0';
                if (x >= 0 && x <= 9)
                {
                    
                   mul =mul* x;
                }
                
            
            }
            Console.WriteLine("Multiplication : " + mul);
            

        }
    }
}
