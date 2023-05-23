using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class AdditionOfTwoArrays
    {
        static void wain()
        {
            int [] a= { 1, 2, 3, 4, 8, 7, 9, 6, 5 };
            int [] b= { 4, 5, 6, 7, 8 };
            int leng = a.Length;

            if (a.Length < b.Length)
            {
                leng = b.Length;
            }
            for (int i = 0; i < leng; i++)
            {
                try
                {
                    Console.WriteLine(a[i] + b[i] + " ");
                }
                catch (Exception e)
                {
                    if (a.Length < b.Length)
                    {
                        Console.WriteLine(b[i]);
                    }
                    else
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }
    }
}
