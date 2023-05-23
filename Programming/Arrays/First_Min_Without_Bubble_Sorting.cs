using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class First_Min_Without_Bubble_Sorting
    {
        static void vain()
        {
            int [] a= { 10, 1, 10, 8, 9, 7, 2, 1, 3, 0 };
            int fmin = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < fmin)
                {
                    fmin = a[i];
                }
            }

           Console.Write(fmin);

        }
    }
}
