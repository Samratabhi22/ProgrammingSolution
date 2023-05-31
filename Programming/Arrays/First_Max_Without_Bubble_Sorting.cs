using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class First_Max_Without_Bubble_Sorting
    {
        static void Mlkain()
        {
            int []a = { 10, 9, 8, 7, 0, 1, 2, 3, 4, 5 };
            int fmax = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > fmax)
                {
                    fmax = a[i];
                }

            }
            Console.WriteLine(fmax);
            //Console.Write(a.Max());

        }
    }
}
