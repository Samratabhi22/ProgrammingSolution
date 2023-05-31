using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Combination_of_numbers
    {
        public static void Maghin(String[] args)
        {
            Console.WriteLine("8--> combination_of_numbers_whose_sum_is_11");
            int []a = { 1, 3, 5, 2, 8, 9, 10 };
            //a+b=11----> 11-a[i]=b

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == 11)
                    {
                        Console.WriteLine(a[i] + " " + a[j]);
                    }
                }
            }

        }
    }
}
