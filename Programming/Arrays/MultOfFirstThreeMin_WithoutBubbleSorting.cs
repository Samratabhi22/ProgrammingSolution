using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class MultOfFirstThreeMin_WithoutBubbleSorting
    {
        static void bbain()
        {
            int [] a = { 2, 5, 1, 5, 3, 4, 1, 4, 6, 7, 8, 1 };
            int fmin = a[0];
            int smin = a[1];
            int tmin = a[2];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < fmin)
                {
                    tmin = smin;
                    smin = fmin;
                    fmin = a[i];
                }
                if (a[i] < smin && a[i] != fmin)
                {
                    tmin = smin;
                    smin = a[i];
                }
                if (a[i] < tmin && a[i] != fmin && a[i] != smin)
                {
                    tmin = a[i];
                }
            }
            int prod = fmin * smin * tmin;

            Console.WriteLine(fmin);
            Console.WriteLine(smin);
            Console.WriteLine(tmin);
            Console.WriteLine("product of 3 min : " + prod);
        }
    }
}
