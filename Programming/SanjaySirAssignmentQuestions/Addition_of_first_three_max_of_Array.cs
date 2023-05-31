using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Addition_of_first_three_max_of_Array
    {
        static void Madfgin()
        {
            int[] a = { 7, -6, 11, 9, 0, 4 };
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = a[i];
                }
                else if (a[i] > secondMax && a[i] < firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = a[i];
                }
                else if (a[i] > thirdMax && a[i] < secondMax)
                {
                    thirdMax = a[i];
                }
            }
            int sum = firstMax + secondMax + thirdMax;
            Console.WriteLine(firstMax);
            Console.WriteLine(secondMax);
            Console.WriteLine(thirdMax);
            Console.WriteLine("sum is " + sum);
        }
    }
}
