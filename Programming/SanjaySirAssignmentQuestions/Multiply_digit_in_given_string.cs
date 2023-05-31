using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Multiply_digit_in_given_string
    {
        static void Madin()
        {

            // String str = "I a12m goi324ng t12o f124ind t120he pr5oduct of n236umbers ins242ide th25is str2ing2";
            String str = "I a12m3i goi3n4g";
            int tempSum = 0;
            long multiplyResult = 1;
            List<int> list = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= '0' && str[i] <= '9')
                {
                    int num = str[i] - 48;
                    tempSum = tempSum * 10 + num;
                }
                else
                {
                    //System.out.println(tempSum);
                    if (tempSum > 0)
                    {
                        list.Add(tempSum);
                    }
                    tempSum = 0;
                }
            }
            if (tempSum > 0)
            {
                list.Add(tempSum);
            }
            foreach (int integer in list)
            {
                //System.out.println(integer);
                multiplyResult = integer * multiplyResult;
            }
            Console.WriteLine("Multiplication of numbers included in String---> " + multiplyResult);

        }
    }
}
