using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class MergeTwoArrays
    {
        static void sain()
        {
            int []a = { 1, 2, 3, 4, 5, 7, 8, 9 };
            int []b = { 2, 3, 4, 5, 0, 2 };


            int []c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[k] = b[i];
                k++;

            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");

            }


        }
    }
}
