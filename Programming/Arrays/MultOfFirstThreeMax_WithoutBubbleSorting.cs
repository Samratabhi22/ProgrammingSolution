using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class MultOfFirstThreeMax_WithoutBubbleSorting
    {
        static void ddain()
        {
            int [] a = { 10, 2, 5, 1, 5, 3, 4, 1, 4, 6, 7, 8, 10 };
            int fmax = a[0];
            int smax = a[1];
            int tmax = a[2];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > fmax)
                {
                    tmax = smax;
                    smax = fmax;
                    fmax = a[i];
                }
                if (a[i] > smax && a[i] != fmax)
                {
                    tmax = smax;
                    smax = a[i];
                }
                if (a[i] > tmax && a[i] != fmax && a[i] != smax)
                {
                    tmax = a[i];
                }
            }
            int prod = fmax * smax * tmax;

            Console.WriteLine(fmax);
            Console.WriteLine(smax);
            Console.WriteLine(tmax);
            Console.WriteLine("product of 3 max : " + prod);
        }
    }
}
